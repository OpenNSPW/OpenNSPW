using Aigamo.Saruhashi.MonoGame;
using FontStashSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OpenNspw.Controls
{
	internal sealed class DynamicSpriteFontWrapper : IMonoGameFont
	{
		public DynamicSpriteFont DynamicSpriteFont { get; }

		public DynamicSpriteFontWrapper(DynamicSpriteFont dynamicSpriteFont)
		{
			DynamicSpriteFont = dynamicSpriteFont;
		}

		public void Draw(SpriteBatch spriteBatch, string? text, Vector2 position, Color color) => DynamicSpriteFont.DrawText(spriteBatch, text, position, color);

		public Vector2 MeasureString(string? text) => DynamicSpriteFont.MeasureString(text);
	}
}
