using System;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.TextureAtlases;

namespace OpenNspw.Effects
{
	internal enum SpriteEffectMode
	{
		Zero,
		One,
		Two,
		Three,
		Four,
	}

	internal sealed class SpriteEffect : IEffect
	{
		public EffectLayer Layer { get; }
		public string Name { get; }
		public int Frame { get; }
		public int RemainingTicks { get; private set; }
		public SpriteEffectMode Mode { get; }
		public WPos Center { get; private set; }

		public SpriteEffect(EffectLayer layer, string name, int duration, SpriteEffectMode mode, WPos center, int frame)
		{
			Layer = layer;
			Name = name;
			RemainingTicks = duration;
			Mode = mode;
			Center = center;
			Frame = frame;
		}

		public void Update(World world)
		{
			RemainingTicks--;

			if (RemainingTicks == 0)
				world.AddFrameEndAction(w => w.Remove(this));
		}

		public void Draw(World world, Graphics graphics, Camera camera)
		{
			// TODO: check visibility

			var texture = world.Assets.Textures[Name];
			var frame = Mode switch
			{
				SpriteEffectMode.Zero => Frame,
				SpriteEffectMode.One => Frame + world.WorldTick % 2,
				SpriteEffectMode.Two => Frame + world.LocalRandom.Next(2),
				SpriteEffectMode.Three => Frame,
				SpriteEffectMode.Four => Frame + world.LocalRandom.Next(2),
				_ => throw new InvalidOperationException(),
			};
			var sprite = new Sprite(new TextureRegion2D(texture, new Rectangle(40 * frame, 0, 40, 40)));
			var center = Mode switch
			{
				SpriteEffectMode.Zero => Center,
				SpriteEffectMode.One => Center,
				SpriteEffectMode.Two => Center + new WVec(world.LocalRandom.Next(-5, 5), world.LocalRandom.Next(-5, 5)),
				SpriteEffectMode.Three => throw new NotImplementedException(),
				SpriteEffectMode.Four => Center,
				_ => throw new InvalidOperationException(),
			};
			graphics.DrawImage(MonoGameImage.Create(sprite), camera.WorldToScreen(center).ToPoint().ToDrawingPoint());
		}
	}
}
