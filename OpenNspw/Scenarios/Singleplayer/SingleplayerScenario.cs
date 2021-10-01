using Microsoft.Xna.Framework;
using OpenNspw.Activities;
using OpenNspw.Components;
using OpenNspw.Interop;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal abstract class SingleplayerScenario : Scenario
	{
		protected Emulator Emulator { get; }

		protected SingleplayerScenario()
		{
			using var stream = TitleContainer.OpenStream("Content/Interop/NSPW_122.bin");
			Emulator = new Emulator(stream);
		}

		public override void Initialize(World world, Camera camera)
		{
			world.SetLocalPlayerIndex(Emulator.data.your_side - 1);

			for (var i = 0; i < Emulator.data.unit.Length; i++)
			{
				var interopUnit = Emulator.data.unit[i];
				if (interopUnit.used == 0)
					continue;

				var name = interopUnit.used switch
				{
					1 => interopUnit.kind switch
					{
						1 => "bb_jpn",
						2 => "ca_jpn",
						3 => "dd_jpn",
						4 => "ss_jpn",
						5 => "cv_jpn",
						6 => "cvl_jpn",
						7 => interopUnit.type switch
						{
							0 => "ft_jpn",
							1 => "shinden",
							_ => throw new InvalidOperationException(),
						},
						8 => "at_jpn",
						9 => "bm_jpn",
						10 => "tr_jpn",
						11 => "ap_jpn",
						12 => "sp_jpn",
						13 => "ct_jpn",
						14 => "mn_jpn",
						15 => "gf1_jpn",
						16 => "gf2_jpn",
						17 => "gf3_jpn",
						_ => throw new InvalidOperationException(),
					},
					2 => interopUnit.kind switch
					{
						1 => "bb_usa",
						2 => "ca_usa",
						3 => "dd_usa",
						4 => "ss_usa",
						5 => "cv_usa",
						6 => "cvl_usa",
						7 => interopUnit.type switch
						{
							0 => "ft_usa",
							1 => "g_ft_usa",
							_ => throw new InvalidOperationException(),
						},
						8 => "at_usa",
						9 => "bm_usa",
						10 => "tr_usa",
						11 => "ap_usa",
						12 => "sp_usa",
						13 => "ct_usa",
						14 => "mn_usa",
						15 => "gf1_usa",
						16 => "gf2_usa",
						17 => "gf3_usa",
						_ => throw new InvalidOperationException(),
					},
					_ => throw new InvalidOperationException(),
				};

				if (interopUnit.ctgry == 2 && interopUnit.info[0] == 2)
				{
					var unit = Unit.Create(
						id: i,
						world,
						name,
						owner: world.Players[interopUnit.used - 1],
						center: new WPos((float)interopUnit.x, (float)interopUnit.y),
						angle: WAngle.FromDegrees((float)interopUnit.drctn)
					);
					world.Add(unit, toAll: true);

					var airplane = unit.GetRequiredComponent<Airplane>();
					var hangar = world.AllUnits[interopUnit.info[1]].GetRequiredComponent<Hangar>();
					hangar.Add(airplane);
					hangar.Park(airplane);
				}
				else
				{
					var unit = Unit.Create(
						id: i,
						world,
						name,
						owner: world.Players[interopUnit.used - 1],
						center: new WPos((float)interopUnit.x, (float)interopUnit.y),
						angle: WAngle.FromDegrees((float)interopUnit.drctn)
					);
					world.Add(unit, toAll: true);

					if (unit.TryGetComponent<Airplane>(out var airplane))
					{
						airplane.Stop = false;

						unit.QueueActivity(new Move(airplane, speed: 0, acceleration: 0));
					}
				}
			}

			camera.Position = new WPos((float)Emulator.data.cmbt_x, (float)Emulator.data.cmbt_y);
		}
	}
}
