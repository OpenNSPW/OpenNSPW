using System.Linq;
using Aigamo.Saruhashi;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using OpenNspw.Controls;
using OpenNspw.Orders;
using OpenNspw.Scenarios;

namespace OpenNspw.Screens
{
	internal sealed class GameScreen : Screen
	{
		private readonly Scenario _scenario;
		private readonly OrderManager _orderManager;

		private MainForm _mainForm = default!;

		private SoundEffectInstance _soundEffectInstance = default!;

		public GameScreen(MainGame game, Scenario scenario) : base(game)
		{
			_scenario = scenario;
			_orderManager = new OrderManager(new EchoConnection());
		}

		public override void LoadContent()
		{
			base.LoadContent();

			var map = new Map(_scenario.MapName);
			var players = _scenario.Players.Select(p => new Player(p.Faction, p.Color));
			var camera = new Camera(map.Bounds, flipY: true)
			{
				Viewport = WRect.FromCenter(WPos.Zero, new WVec(768, 768)),
			};
			var world = World.Create(_scenario, _orderManager, map, players, camera);

			_mainForm = new MainForm(world, camera, GraphicsDevice);
			WindowManager.Root.Controls.Add(_mainForm);
			_mainForm.Show();
			_mainForm.Focus();

			_soundEffectInstance = Assets.SoundEffects["SoundEffects/sea1"].CreateInstance();
			_soundEffectInstance.IsLooped = true;
			_soundEffectInstance.Play();

			_orderManager.StartGame();
		}

		public override void UnloadContent()
		{
			base.UnloadContent();

			_soundEffectInstance.Stop();
			_soundEffectInstance.Dispose();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);

			_mainForm.Update(gameTime);
		}

		public override void Draw(GameTime gameTime)
		{
		}
	}
}
