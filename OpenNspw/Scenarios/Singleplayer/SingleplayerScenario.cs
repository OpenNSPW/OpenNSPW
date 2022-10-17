using Aigamo.Enzan;
using Microsoft.Xna.Framework;
using OpenNspw.Activities;
using OpenNspw.Components;
using OpenNspw.Interop;

namespace OpenNspw.Scenarios.Singleplayer;

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
					10 => interopUnit.arm[0] switch
					{
						17 => "tr_jpn",
						30 => "tr_sp_jpn",
						31 => "tr_ap_jpn",
						32 => "tr_gf1_jpn",
						33 => "tr_gf2_jpn",
						34 => "tr_gf3_jpn",
						_ => throw new InvalidOperationException(),
					},
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
					10 => interopUnit.arm[0] switch
					{
						17 => "tr_usa",
						30 => "tr_sp_usa",
						31 => "tr_ap_usa",
						32 => "tr_gf1_usa",
						33 => "tr_gf2_usa",
						34 => "tr_gf3_usa",
						_ => throw new InvalidOperationException(),
					},
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

internal sealed class Scenario1 : SingleplayerScenario
{
	public Scenario1()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42A2E0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario2 : SingleplayerScenario
{
	public Scenario2()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42A6C0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario3 : SingleplayerScenario
{
	public Scenario3()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42AA60));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario4 : SingleplayerScenario
{
	public Scenario4()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42AC90));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario5 : SingleplayerScenario
{
	public Scenario5()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42AF40));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario6 : SingleplayerScenario
{
	public Scenario6()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42B3A0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario7 : SingleplayerScenario
{
	public Scenario7()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42B8A0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario8 : SingleplayerScenario
{
	public Scenario8()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42C480));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario9 : SingleplayerScenario
{
	public Scenario9()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42CED0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario10 : SingleplayerScenario
{
	public Scenario10()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42D3C0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario100 : SingleplayerScenario
{
	public Scenario100()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x41F570));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario101 : SingleplayerScenario
{
	public Scenario101()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x41F830));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario102 : SingleplayerScenario
{
	public Scenario102()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x41FD60));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario103 : SingleplayerScenario
{
	public Scenario103()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x420260));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario104 : SingleplayerScenario
{
	public Scenario104()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x4207C0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario105 : SingleplayerScenario
{
	public Scenario105()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x420DE0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario106 : SingleplayerScenario
{
	public Scenario106()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x421310));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario107 : SingleplayerScenario
{
	public Scenario107()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x421830));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario108 : SingleplayerScenario
{
	public Scenario108()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x423940));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario109 : SingleplayerScenario
{
	public Scenario109()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x424DD0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario200 : SingleplayerScenario
{
	public Scenario200()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x421DB0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario201 : SingleplayerScenario
{
	public Scenario201()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x422820));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario202 : SingleplayerScenario
{
	public Scenario202()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x422D10));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario203 : SingleplayerScenario
{
	public Scenario203()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x422F40));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario204 : SingleplayerScenario
{
	public Scenario204()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x4241B0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario205 : SingleplayerScenario
{
	public Scenario205()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x424760));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario206 : SingleplayerScenario
{
	public Scenario206()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x421A80));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario207 : SingleplayerScenario
{
	public Scenario207()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x425D60));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario208 : SingleplayerScenario
{
	public Scenario208()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x425510));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario209 : SingleplayerScenario
{
	public Scenario209()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x426270));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario300 : SingleplayerScenario
{
	public Scenario300()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x426DE0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario301 : SingleplayerScenario
{
	public Scenario301()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x427030));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario302 : SingleplayerScenario
{
	public Scenario302()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x4278B0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario303 : SingleplayerScenario
{
	public Scenario303()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x428020));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario304 : SingleplayerScenario
{
	public Scenario304()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x4287E0));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario305 : SingleplayerScenario
{
	public Scenario305()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x428C60));

		base.Initialize(world, camera);
	}
}

internal sealed class Scenario306 : SingleplayerScenario
{
	public Scenario306()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x429310));

		base.Initialize(world, camera);
	}
}
