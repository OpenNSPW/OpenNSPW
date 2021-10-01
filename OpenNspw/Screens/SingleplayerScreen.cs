using Aigamo.Saruhashi;
using Microsoft.Xna.Framework;
using OpenNspw.Controls;
using OpenNspw.Scenarios;
using OpenNspw.Scenarios.Singleplayer;

namespace OpenNspw.Screens
{
	internal sealed class SingleplayerScreen : Screen
	{
		private static readonly (string Title, Type ScenarioType)[] s_scenarios = new[]
		{
			("Military Exercises in Hawaii", typeof(Scenario1)),
			("Attack on Pearl Harbor", typeof(Scenario2)),
			("Battle of Wake Island", typeof(Scenario3)),
			("Battle of the Coral Sea", typeof(Scenario4)),
			("Battle of Midway", typeof(Scenario5)),
			("Battle of the Santa Cruz Islands", typeof(Scenario6)),
			("Naval South Pacific War", typeof(Scenario7)),
			("Operation Hailstone", typeof(Scenario8)),
			("Battle of the Philippine Sea", typeof(Scenario9)),
			("Battle of Japan", typeof(Scenario10)),

			("The Silent Service", typeof(Scenario100)),
			("Fleet-to-fleet Battle (IJN)", typeof(Scenario101)),
			("Fleet-to-fleet Battle (USN)", typeof(Scenario102)),
			("Deep Blue Air Force - Spacetime Odyssey", typeof(Scenario103)),
			("Invasion of Guadalcanal", typeof(Scenario104)),
			("Carrier-to-carrier Battle (IJN)", typeof(Scenario105)),
			("Carrier-to-carrier Battle (USN)", typeof(Scenario106)),
			("Operation Vengeance", typeof(Scenario107)),
			("Samurai!", typeof(Scenario108)),
			("Deep Blue Air Force - Gambit", typeof(Scenario109)),

			("Battle of Guadalcanal", typeof(Scenario200)),
			("Hiryu (Flying Dragon)", typeof(Scenario201)),
			("Bombing of Tokyo", typeof(Scenario202)),
			("USS Enterprise", typeof(Scenario203)),
			("Deep Blue Air Force - Air Supremacy", typeof(Scenario204)),
			("Deep Blue Air Force - Rescue", typeof(Scenario205)),
			("Battle of the East China Sea", typeof(Scenario206)),
			("Morning Kantai。", typeof(Scenario207)),
			("Deep Blue Air Force - Ordeal", typeof(Scenario208)),
			("Invasion of Midway", typeof(Scenario209)),

			("Doolittle Raid", typeof(Scenario300)),
			("Invasion of Port Moresby", typeof(Scenario301)),
			("Operation MI", typeof(Scenario302)),
			("Deep Blue Air Force - Mission: Impossible", typeof(Scenario303)),
			("Japan Campaign", typeof(Scenario304)),
			("Operation Ten-Go", typeof(Scenario305)),
			("The Silent Service, Once Again", typeof(Scenario306)),
		};

		private ScenarioBrowserForm _scenarioBrowserForm = default!;

		public SingleplayerScreen(MainGame game) : base(game)
		{
		}

		public override void LoadContent()
		{
			_scenarioBrowserForm = new ScenarioBrowserForm(Game.Assets, Game.Sound, s_scenarios);
			_scenarioBrowserForm.FormClosed += (sender, e) =>
			{
				if (_scenarioBrowserForm.SelectedScenario is Type scenarioType && Activator.CreateInstance(scenarioType) is Scenario scenario)
					ScreenManager.LoadScreen(new GameScreen(Game, scenario));
			};
			WindowManager.Root.Controls.Add(_scenarioBrowserForm);
			_scenarioBrowserForm.Show();
			_scenarioBrowserForm.Focus();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		public override void Draw(GameTime gameTime)
		{
		}
	}
}
