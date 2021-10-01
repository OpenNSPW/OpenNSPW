using Aigamo.Saruhashi;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameScreenBase = MonoGame.Extended.Screens.GameScreen;
using XnaKeys = Microsoft.Xna.Framework.Input.Keys;

namespace OpenNspw.Screens;

internal abstract class Screen : GameScreenBase
{
	protected new MainGame Game { get; }

	protected Screen(MainGame game) : base(game)
	{
		Game = game;
	}

	protected SpriteBatch SpriteBatch => Game.SpriteBatch;

	protected WindowManager WindowManager => Game.WindowManager;

	public override void UnloadContent()
	{
		WindowManager.Root.Controls.Clear();
	}

	public override void Update(GameTime gameTime)
	{
		if (this is not MainMenuScreen && Keyboard.GetState().IsKeyDown(XnaKeys.F4))
			ScreenManager.LoadScreen(new MainMenuScreen(Game));
	}
}
