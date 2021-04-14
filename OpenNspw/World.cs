using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;

namespace OpenNspw
{
	internal sealed class World
	{
		public int FrameCount { get; set; }

		public Camera Camera { get; }

		private readonly SortedDictionary<int, Unit> _units = new();

		public Selection Selection { get; } = new();

		public Map Map { get; }

		public World()
		{
			Map = new Map("Content/Maps/south_pacific.dat");
			Camera = new Camera(Map.Bounds, flipY: true);
		}

		public IEnumerable<Unit> Units => _units.Values;

		private int _nextUnitId = 1;

		public Unit CreateUnit(string name, Player owner, WPos center, WAngle angle)
		{
			var unit = new Unit(_nextUnitId++, this, name, owner, center, angle);
			return unit;
		}

		public void Add(Unit unit) => _units.Add(unit.Id, unit);

		public void Update()
		{
		}

		public void Draw(Graphics graphics, Camera camera)
		{
			Map.Draw(this, graphics, camera);

			foreach (var unit in Units.Where(u => camera.Viewport.Intersects(WRect.FromCenter(u.Center, new WVec(80, 80)))))
				unit.Draw(graphics, camera);
		}
	}
}
