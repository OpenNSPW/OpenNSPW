using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OpenNspw
{
	public class MainGame : Game
	{
		private readonly GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch = default!;

		public MainGame()
		{
			_graphics = new GraphicsDeviceManager(this);

			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			_graphics.PreferredBackBufferWidth = 1024;
			_graphics.PreferredBackBufferHeight = 768;
			_graphics.ApplyChanges();

			Window.Title = "OpenNSPW";

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			base.Draw(gameTime);
		}
	}
}
