using System;
using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using OpenNspw.Activities;
using OpenNspw.Components;
using DPoint = System.Drawing.Point;

namespace OpenNspw.Controls
{
	internal enum DeckState
	{
		Deck,
		Hangar,
	}

	internal sealed class Deck : Controller
	{
		private readonly World _world;

		public DeckState DeckState { get; set; }

		public Deck(World world, Camera camera) : base(world, camera)
		{
			_world = world;
		}

		private IEnumerable<Unit> Units
		{
			get
			{
				static bool IsInFlightDeck(Airplane airplane) => airplane.Self.CurrentActivity switch
				{
					TakeOff takeOff => takeOff.State >= TakeOff.TakeOffState.TaxiOut,
					Land land => true,
					_ => false,
				};

				var airplanes = MouseFocusUnit?.GetComponent<Hangar>()?.Airplanes ?? Array.Empty<Airplane>();
				return DeckState switch
				{
					DeckState.Deck => airplanes.Where(a => IsInFlightDeck(a)).Select(a => a.Self),
					DeckState.Hangar => airplanes.Where(a => !IsInFlightDeck(a)).Select(a => a.Self),
					_ => throw new InvalidOperationException(),
				};
			}
		}

		public void Update()
		{
			Update(Units.Where(u => !u.IsMoving));
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			if (MouseFocusUnit is not null)
			{
				if (_world.Assets.Textures.TryGetValue($"Textures/Units/{MouseFocusUnit.Name}_{DeckState.ToString().ToLowerInvariant()}", out var texture))
					e.Graphics.DrawImage(MonoGameImage.Create(texture, Color.White), DPoint.Empty);
			}

			DrawBackground(e, Units);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Draw(e, Units);
		}

		public void ToggleDeckState()
		{
			switch (DeckState)
			{
				case DeckState.Deck:
					DeckState = DeckState.Hangar;
					break;

				case DeckState.Hangar:
					DeckState = DeckState.Deck;
					break;
			}
		}
	}
}
