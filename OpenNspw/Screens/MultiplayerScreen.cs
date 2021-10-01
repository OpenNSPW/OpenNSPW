using Aigamo.Saruhashi;
using Microsoft.Xna.Framework;
using OpenNspw.Controls;
using OpenNspw.Scenarios;
using OpenNspw.Scenarios.Multiplayer;

namespace OpenNspw.Screens
{
	internal sealed class MultiplayerScreen : Screen
	{
		private static readonly (string Title, Type ScenarioType)[] s_scenarios = new[]
		{
			("Carrier-to-carrier Battle 1", typeof(Scenario1)),
			("Carrier-to-carrier Battle 2", typeof(Scenario2)),
			("Carrier-to-carrier Battle 3", typeof(Scenario3)),
			("Fleet-to-fleet Battle 1", typeof(Scenario4)),
			("Fleet-to-fleet Battle 2", typeof(Scenario5)),
			("Invasion of Midway 1", typeof(Scenario6)),
			("Invasion of Midway 2", typeof(Scenario7)),
			("Battle of the Central Pacific", typeof(Scenario8)),

			("Battle of Guadalcanal 1", typeof(Scenario101)),
			("Battle of Guadalcanal 2", typeof(Scenario102)),
			("Japan Campaign", typeof(Scenario103)),
			("Battle of the South Pacific 1", typeof(Scenario104)),
			("Battle of the South Pacific 2", typeof(Scenario105)),
			("Guadalcanal Campaign", typeof(Scenario106)),
		};

		private ScenarioBrowserForm _scenarioBrowserForm = default!;

		public MultiplayerScreen(MainGame game) : base(game)
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
