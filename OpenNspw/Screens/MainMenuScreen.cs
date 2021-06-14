using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Sprites;
using DPoint = System.Drawing.Point;
using DRect = System.Drawing.Rectangle;
using DSize = System.Drawing.Size;

namespace OpenNspw.Screens
{
	internal sealed class MainMenuScreen : Screen
	{
		private Form _form = default!;
		private Button _singleplayerButton = default!;
		private Button _multiplayerButton = default!;
		private Button _quitButton = default!;

		public MainMenuScreen(MainGame game) : base(game)
		{
		}

		public override void LoadContent()
		{
			_form = new Form
			{
				Size = new DSize(1024, 768),
			};
			_form.Paint += (sender, e) =>
			{
				e.Graphics.DrawImage(MonoGameImage.Create(new Sprite(Assets.Textures["Textures/nspw"])), new DPoint(1024 / 2, 768 / 2));
			};
			WindowManager.Root.Controls.Add(_form);
			_form.Show();
			_form.Focus();

			_singleplayerButton = new Button
			{
				Bounds = new DRect(67, 690, 140, 35),
				Text = "Singleplayer",
			};
			_singleplayerButton.MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Left)
					Assets.SoundEffects["SoundEffects/btn_4"].Play();
			};
			_singleplayerButton.Click += (sender, e) => ScreenManager.LoadScreen(new SingleplayerScreen(Game));
			_form.Controls.Add(_singleplayerButton);

			_multiplayerButton = new Button
			{
				Bounds = new DRect(217, 690, 140, 35),
				Text = "Multiplayer",
			};
			_multiplayerButton.MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Left)
					Assets.SoundEffects["SoundEffects/btn_4"].Play();
			};
			_multiplayerButton.Click += (sender, e) => ScreenManager.LoadScreen(new MultiplayerScreen(Game));
			_form.Controls.Add(_multiplayerButton);

			_quitButton = new Button
			{
				Bounds = new DRect(817, 690, 140, 35),
				Text = "Quit",
			};
			_quitButton.MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Left)
					Assets.SoundEffects["SoundEffects/btn_4"].Play();
			};
			_quitButton.Click += (sender, e) => Game.Exit();
			_form.Controls.Add(_quitButton);
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
