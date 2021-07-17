using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.TextureAtlases;
using OpenNspw.Activities;
using OpenNspw.Components;
using OpenNspw.Orders;

namespace OpenNspw
{
	internal sealed class Unit
	{
		public int Id { get; }
		public World World { get; }
		public Player Owner { get; }
		public string Name { get; }
		public Texture2D Texture { get; set; }

		public ComponentCollection Components { get; } = new();

		public Activity? CurrentActivity { get; set; }

		private readonly IUnit _unit;
		private readonly Health? _health;
		private readonly IOrderHandler[] _orderHandlers;
		private readonly IUpdatable[] _updatables;

		public T GetRequiredComponent<T>() where T : notnull => Components.GetRequiredComponent<T>();

		public T? GetComponent<T>() => Components.GetComponent<T>();

		public bool TryGetComponent<T>([NotNullWhen(true)] out T? component)
		{
			component = GetComponent<T>();
			return component is not null;
		}

		public bool HasComponent<T>() => GetComponent<T>() is not null;

		private Unit(int id, World world, string name, Player owner)
		{
			Id = id;
			World = world;
			Name = name;
			Owner = owner;

			Texture = world.Assets.Textures[$"Textures/Units/{name}"];

			foreach (var component in UnitOptions.Components[name])
				Components.Add(component.CreateComponent(this));

			_unit = Components.OfType<IUnit>().Single();
			_health = GetComponent<Health>();
			_orderHandlers = Components.OfType<IOrderHandler>().ToArray();
			_updatables = Components.OfType<IUpdatable>().ToArray();
		}

		private void Initialize()
		{
			foreach (var listener in Components.OfType<ICreatedEventListener>())
				listener.OnCreated(this);
		}

		public static Unit Create(int id, World world, string name, Player owner, WPos center, WAngle angle)
		{
			var unit = new Unit(id, world, name, owner)
			{
				Center = center,
				Angle = angle,
			};
			unit.Initialize();
			return unit;
		}

		public WPos Center
		{
			get => _unit.Center;
			set => _unit.Center = value;
		}

		public WAngle Angle
		{
			get => _unit.Angle;
			set => _unit.Angle = value;
		}

		public bool IsMoving => _unit.IsMoving;
		public IEnumerable<WPos> Waypoints => _unit.Waypoints;

		public DamageState DamageState => _health?.DamageState ?? DamageState.Undamaged;
		public bool IsDead => _health?.IsDead ?? false;

		public void HandleOrder(IOrder order)
		{
			foreach (var handler in _orderHandlers)
				handler.HandleOrder(World, order);
		}

		public void Update()
		{
			CurrentActivity = CurrentActivity?.Update(this);

			foreach (var updatable in _updatables)
				updatable.Update(this);
		}

		public void Draw(Graphics graphics, Camera camera)
		{
			var sprite = new Sprite(new TextureRegion2D(Texture, new Rectangle(80 * (Angle.Quantize() % (Texture.Width / 80)), 0, 80, 80)));
			graphics.DrawImage(MonoGameImage.Create(sprite), camera.WorldToScreen(Center).ToPoint().ToDrawingPoint());
		}
	}
}
