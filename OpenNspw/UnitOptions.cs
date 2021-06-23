using System.Collections.Generic;
using OpenNspw.Components;

namespace OpenNspw
{
	internal static class UnitOptions
	{
		public static readonly IReadOnlyDictionary<string, IComponentOptions[]> Components = new Dictionary<string, IComponentOptions[]>
		{
			{
				"bb_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Battleship",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 1000,
					},
					new HealthOptions
					{
						MaxHP = 40,
					},
				}
			},
			{
				"bb_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Battleship",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 1000,
					},
					new HealthOptions
					{
						MaxHP = 40,
					},
				}
			},
			{
				"yamato",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Yamato",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 1350,
					},
					new HealthOptions
					{
						MaxHP = 56,
					},
				}
			},
			{
				"ca_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Cruiser",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 600,
					},
					new HealthOptions
					{
						MaxHP = 32,
					},
				}
			},
			{
				"ca_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Cruiser",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 600,
					},
					new HealthOptions
					{
						MaxHP = 32,
					},
				}
			},
			{
				"claa_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Antiaircraft Cruiser",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 450,
					},
					new HealthOptions
					{
						MaxHP = 25,
					},
				}
			},
			{
				"claa_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Antiaircraft Cruiser",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 450,
					},
					new HealthOptions
					{
						MaxHP = 28,
					},
				}
			},
			{
				"dd_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Destroyer",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 120,
					},
					new HealthOptions
					{
						MaxHP = 18,
					},
				}
			},
			{
				"dd_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Destroyer",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 120,
					},
					new HealthOptions
					{
						MaxHP = 18,
					},
				}
			},
			{
				"dde_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Escort Destroyer",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 120,
					},
					new HealthOptions
					{
						MaxHP = 12,
					},
				}
			},
			{
				"dde_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Escort Destroyer",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 120,
					},
					new HealthOptions
					{
						MaxHP = 16,
					},
				}
			},
			{
				"ss_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Submarine",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 25,
					},
					new HealthOptions
					{
						MaxHP = 7,
					},
				}
			},
			{
				"ss_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Submarine",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 25,
					},
					new HealthOptions
					{
						MaxHP = 7,
					},
				}
			},
			{
				"cv_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Aircraft Carrier",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 100,
					},
					new HangarOptions
					{
						Capacity = 12,
						Offset = 25,
					},
					new HealthOptions
					{
						MaxHP = 32,
					},
				}
			},
			{
				"cv_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Aircraft Carrier",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 100,
					},
					new HangarOptions
					{
						Capacity = 12,
						Offset = 25,
					},
					new HealthOptions
					{
						MaxHP = 37,
					},
				}
			},
			{
				"essex",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Essex",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 110,
					},
					new HangarOptions
					{
						Capacity = 14,
						Offset = 25,
					},
					new HealthOptions
					{
						MaxHP = 42,
					},
				}
			},
			{
				"cvl_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Light Aircraft Carrier",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 80,
					},
					new HangarOptions
					{
						Capacity = 8,
						Offset = 25,
					},
					new HealthOptions
					{
						MaxHP = 27,
					},
				}
			},
			{
				"cvl_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Light Aircraft Carrier",
					},
					new ShipOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 80,
					},
					new HangarOptions
					{
						Capacity = 8,
						Offset = 25,
					},
					new HealthOptions
					{
						MaxHP = 32,
					},
				}
			},
			{
				"ft_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Fighter",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 35,
					},
					new HealthOptions
					{
						MaxHP = 14,
					},
				}
			},
			{
				"ft_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Fighter",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 40,
					},
					new HealthOptions
					{
						MaxHP = 18,
					},
				}
			},
			{
				"g_ft_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Interceptor",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 50,
					},
					new HealthOptions
					{
						MaxHP = 11,
					},
				}
			},
			{
				"g_ft_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Interceptor",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 60,
					},
					new HealthOptions
					{
						MaxHP = 28,
					},
				}
			},
			{
				"shinden",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Shinden",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 60,
					},
					new HealthOptions
					{
						MaxHP = 32,
					},
				}
			},
			{
				"at_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Attack Bomber",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 1,
					},
					new HealthOptions
					{
						MaxHP = 16,
					},
				}
			},
			{
				"at_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Attack Bomber",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 1,
					},
					new HealthOptions
					{
						MaxHP = 20,
					},
				}
			},
			{
				"bm_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Strategic Bomber",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 9,
					},
					new HealthOptions
					{
						MaxHP = 32,
					},
				}
			},
			{
				"bm_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Strategic Bomber",
					},
					new AirplaneOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 20,
					},
					new HealthOptions
					{
						MaxHP = 50,
					},
				}
			},
			{
				"tr_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Transport",
					},
					new ShipOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 9,
					},
				}
			},
			{
				"tr_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Transport",
					},
					new ShipOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 9,
					},
				}
			},
			{
				"ap_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Airfield",
					},
					new BuildingOptions
					{
					},
					new HangarOptions
					{
						Capacity = 16,
						Offset = 35,
					},
					new HealthOptions
					{
						MaxHP = 260,
					},
				}
			},
			{
				"ap_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Airfield",
					},
					new BuildingOptions
					{
					},
					new HangarOptions
					{
						Capacity = 16,
						Offset = 35,
					},
					new HealthOptions
					{
						MaxHP = 260,
					},
				}
			},
			{
				"sp_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Military Port",
					},
					new BuildingOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 320,
					},
				}
			},
			{
				"sp_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Military Port",
					},
					new BuildingOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 320,
					},
				}
			},
			{
				"ct_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "City",
					},
					new BuildingOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 150,
					},
				}
			},
			{
				"ct_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "City",
					},
					new BuildingOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 150,
					},
				}
			},
			{
				"mn_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Mine",
					},
					new BuildingOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 150,
					},
				}
			},
			{
				"mn_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Mine",
					},
					new BuildingOptions
					{
					},
					new HealthOptions
					{
						MaxHP = 150,
					},
				}
			},
			{
				"gf1_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Trench",
					},
					new BuildingOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 700,
					},
					new HealthOptions
					{
						MaxHP = 180,
					},
				}
			},
			{
				"gf1_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Trench",
					},
					new BuildingOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 700,
					},
					new HealthOptions
					{
						MaxHP = 180,
					},
				}
			},
			{
				"gf2_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Pillbox",
					},
					new BuildingOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 1500,
					},
					new HealthOptions
					{
						MaxHP = 320,
					},
				}
			},
			{
				"gf2_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Pillbox",
					},
					new BuildingOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 1500,
					},
					new HealthOptions
					{
						MaxHP = 320,
					},
				}
			},
			{
				"gf3_jpn",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Fortress",
					},
					new BuildingOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 2000,
					},
					new HealthOptions
					{
						MaxHP = 400,
					},
				}
			},
			{
				"gf3_usa",
				new IComponentOptions[]
				{
					new TooltipOptions
					{
						Name = "Fortress",
					},
					new BuildingOptions
					{
					},
					new ArmamentOptions
					{
						MaxAmmo = 2000,
					},
					new HealthOptions
					{
						MaxHP = 400,
					},
				}
			},
		};
	}
}
