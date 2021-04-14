using System;
using Aigamo.Saruhashi;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using OpenNspw.Controls;

namespace OpenNspw.Screens
{
	internal sealed class GameScreen : Screen
	{
		private readonly World _world;

		private MainForm _mainForm = default!;

		private SoundEffectInstance _soundEffectInstance = default!;

		public GameScreen(MainGame game) : base(game)
		{
			_world = new World();
		}

		public override void LoadContent()
		{
			base.LoadContent();

			_mainForm = new MainForm(_world, GraphicsDevice);
			WindowManager.Root.Controls.Add(_mainForm);
			_mainForm.Show();
			_mainForm.Focus();

			_soundEffectInstance = Assets.SoundEffects["SoundEffects/sea1"].CreateInstance();
			_soundEffectInstance.IsLooped = true;
			_soundEffectInstance.Play();
		}

		public override void UnloadContent()
		{
			base.UnloadContent();

			_soundEffectInstance.Stop();
			_soundEffectInstance.Dispose();
		}

		private TimeSpan _previousTotalGameTime;

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);

			_mainForm.Update();

			var delta = gameTime.TotalGameTime - _previousTotalGameTime;
			if (delta >= TimeSpan.FromMilliseconds(50))
			{
				_previousTotalGameTime = gameTime.TotalGameTime;

				for (var i = 0; i < _mainForm.GameSpeed; i++)
				{
					_world.Update();
				}

				_world.FrameCount++;
			}
		}

		public override void Draw(GameTime gameTime)
		{
		}
	}
}
