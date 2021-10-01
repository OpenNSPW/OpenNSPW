using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using FontStashSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Input.InputListeners;
using MonoGame.Extended.Screens;
using MonoGame.Extended.ViewportAdapters;
using OpenNspw.Controls;
using OpenNspw.Screens;
using DRect = System.Drawing.Rectangle;
using SaruhashiKeys = Aigamo.Saruhashi.Keys;
using SaruhashiMouseListener = Aigamo.Saruhashi.MonoGame.MouseListener;
using XnaKeys = Microsoft.Xna.Framework.Input.Keys;

namespace OpenNspw;

internal sealed class MainGame : Game
{
	private readonly GraphicsDeviceManager _graphics;
	public SpriteBatch SpriteBatch { get; private set; } = default!;
	public IAssetManager Assets { get; private set; } = default!;
	public Sound Sound { get; private set; } = default!;

	private readonly ScreenManager _screenManager;
	private ViewportAdapter _viewportAdapter = default!;
	public WindowManager WindowManager { get; private set; } = default!;

	public MainGame()
	{
		_graphics = new GraphicsDeviceManager(this);

		Content.RootDirectory = "Content";
		IsMouseVisible = true;

		_screenManager = Components.Add<ScreenManager>();
	}

	protected override void Initialize()
	{
		_graphics.PreferredBackBufferWidth = 1024;
		_graphics.PreferredBackBufferHeight = 768;
		_graphics.ApplyChanges();

		Window.Title = "OpenNSPW";

		_viewportAdapter = new BoxingViewportAdapter(Window, GraphicsDevice, 1024, 768);

		base.Initialize();
	}

	protected override void LoadContent()
	{
		SpriteBatch = new SpriteBatch(GraphicsDevice);

		Assets = new AssetManager(Content);
		Sound = new Sound(Assets);

		var mouseListener = new SaruhashiMouseListener(_viewportAdapter);
		var keyboardListener = new KeyboardListener(new KeyboardListenerSettings
		{
			InitialDelayMilliseconds = 500,
			RepeatDelayMilliseconds = 30,
		});
		Components.Add(new InputListenerComponent(this, mouseListener, keyboardListener));

		var fontSystem = FontSystemFactory.Create(GraphicsDevice);
		using var stream = TitleContainer.OpenStream("Content/Fonts/FreeSans.ttf");
		fontSystem.AddFont(stream);
		var defaultFont = new DynamicSpriteFontWrapper(fontSystem.GetFont(fontSize: 16));
		WindowManager = new WindowManager(new DRect(0, 0, 1024, 768), new MonoGameGraphicsFactory(SpriteBatch, _viewportAdapter), defaultFont);
		mouseListener.MouseDown += (sender, e) => WindowManager.OnMouseDown(e);
		mouseListener.MouseMove += (sender, e) => WindowManager.OnMouseMove(e);
		mouseListener.MouseUp += (sender, e) => WindowManager.OnMouseUp(e);
		keyboardListener.KeyPressed += (sender, e) => WindowManager.OnKeyDown(new KeyEventArgs((SaruhashiKeys)e.Key));
		keyboardListener.KeyReleased += (sender, e) => WindowManager.OnKeyUp(new KeyEventArgs((SaruhashiKeys)e.Key));
		Window.TextInput += (sender, e) => WindowManager.OnKeyPress(new KeyPressEventArgs(e.Character));

		_screenManager.LoadScreen(new MainMenuScreen(this));
	}

	protected override void Update(GameTime gameTime)
	{
		if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(XnaKeys.Escape))
			Exit();

		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		GraphicsDevice.Clear(Color.CornflowerBlue);

		base.Draw(gameTime);

		WindowManager.Draw();
	}
}
