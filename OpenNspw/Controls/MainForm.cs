using System;
using System.Collections.Generic;
using Aigamo.Saruhashi;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DColor = System.Drawing.Color;
using DPoint = System.Drawing.Point;
using DRect = System.Drawing.Rectangle;
using DSize = System.Drawing.Size;

namespace OpenNspw.Controls
{
	internal sealed class MainForm : Form
	{
		private readonly World _world;
		private readonly Camera _camera;

		private readonly Battlefield _battlefield;
		private readonly Control _sidebar;

		private readonly DynamicLabel _gameSpeedLabel;

		private readonly Control _radarContainer;
		private readonly Radar _radar;

		private const float ScrollAcceleration = 3;
		private const float MaxScrollSpeed = 100;

		[Flags]
		private enum ScrollDirections
		{
			None = 0,
			Left = 1 << 0,
			Up = 1 << 1,
			Right = 1 << 2,
			Down = 1 << 3,
		}

		private static readonly IReadOnlyDictionary<ScrollDirections, WVec> s_scrollOffsets = new Dictionary<ScrollDirections, WVec>
		{
			{ ScrollDirections.Left, new WVec(-1, 0).FlipY() },
			{ ScrollDirections.Up, new WVec(0, -1).FlipY() },
			{ ScrollDirections.Right, new WVec(1, 0).FlipY() },
			{ ScrollDirections.Down, new WVec(0, 1).FlipY() },
		};

		private ScrollDirections _scrollDirections;
		private float _scrollSpeed;

		private int _gameSpeed = 1;
		public int GameSpeed
		{
			get => _gameSpeed;
			private set => _gameSpeed = Math.Clamp(value, 0, 300);
		}

		public MainForm(World world, Camera camera, GraphicsDevice graphicsDevice)
		{
			_world = world;
			_camera = camera;

			Size = new DSize(1024, 768);
			BackColor = DColor.Transparent;
			KeyPreview = true;

			_battlefield = new Battlefield(world, _camera)
			{
				Bounds = new DRect(0, 0, 768, 768),
			};
			Controls.Add(_battlefield);

			_sidebar = new Control
			{
				Bounds = new DRect(768, 0, 256, 768),
			};
			Controls.Add(_sidebar);

			_gameSpeedLabel = new DynamicLabel
			{
				Bounds = new DRect(130, 100, 126, 20),
				ForeColor = DColor.White,
				GetText = () => $"Game Speed: {GameSpeed}",
			};
			_sidebar.Controls.Add(_gameSpeedLabel);

			_radarContainer = new Control
			{
				Bounds = new DRect(0, 768 - 196, 256, 196),
				BackColor = DColor.FromArgb(198, 132, 57),
			};
			_sidebar.Controls.Add(_radarContainer);

			_radar = new Radar(world, _camera, graphicsDevice)
			{
				Location = new DPoint(8, 8),
			};
			_radarContainer.Controls.Add(_radar);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			switch (e.KeyCode)
			{
				case Keys.A:
					_scrollDirections |= ScrollDirections.Left;
					break;

				case Keys.W:
					_scrollDirections |= ScrollDirections.Up;
					break;

				case Keys.D:
					_scrollDirections |= ScrollDirections.Right;
					break;

				case Keys.S:
					_scrollDirections |= ScrollDirections.Down;
					break;

				case Keys.F:
					GameSpeed++;
					break;

				case Keys.G:
					GameSpeed--;
					break;

				case Keys.R:
					GameSpeed = 1;
					break;
			}
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);

			switch (e.KeyCode)
			{
				case Keys.A:
					_scrollDirections &= ~ScrollDirections.Left;
					break;

				case Keys.W:
					_scrollDirections &= ~ScrollDirections.Up;
					break;

				case Keys.D:
					_scrollDirections &= ~ScrollDirections.Right;
					break;

				case Keys.S:
					_scrollDirections &= ~ScrollDirections.Down;
					break;
			}
		}

		private void Scroll()
		{
			_scrollSpeed = (_scrollDirections == ScrollDirections.None)
				? 0
				: Math.Min(_scrollSpeed + ScrollAcceleration, MaxScrollSpeed);

			var delta = WVec.Zero;
			foreach (var kv in s_scrollOffsets)
			{
				if (_scrollDirections.HasFlag(kv.Key))
					delta += kv.Value;
			}
			_camera.Center += delta * _scrollSpeed;
			_battlefield.UpdateSelection();
		}

		private TimeSpan _previousTotalGameTime;

		public void Update(GameTime gameTime)
		{
			_battlefield.Update();

			Scroll();

			var delta = gameTime.TotalGameTime - _previousTotalGameTime;
			if (delta >= TimeSpan.FromMilliseconds(50))
			{
				_previousTotalGameTime = gameTime.TotalGameTime;

				for (var i = 0; i < GameSpeed; i++)
				{
					_world.Update();
				}

				_world.FrameCount++;
			}
		}
	}
}
