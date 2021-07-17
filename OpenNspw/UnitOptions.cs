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
						TurnSpeed = WAngle.FromDegrees(0.3f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.7f,
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
						TurnSpeed = WAngle.FromDegrees(0.3f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.7f,
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
						TurnSpeed = WAngle.FromDegrees(0.27f),
						Acceleration = 0.009f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.63f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.8f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.8f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.8f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.8f,
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
						TurnSpeed = WAngle.FromDegrees(1.3f),
						Acceleration = 0.05f,
						MinSpeed = 0.0f,
						MaxSpeed = 1.00f,
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
						TurnSpeed = WAngle.FromDegrees(1.3f),
						Acceleration = 0.05f,
						MinSpeed = 0.0f,
						MaxSpeed = 1.00f,
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
						TurnSpeed = WAngle.FromDegrees(1.3f),
						Acceleration = 0.05f,
						MinSpeed = 0.0f,
						MaxSpeed = 1.00f,
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
						TurnSpeed = WAngle.FromDegrees(1.3f),
						Acceleration = 0.05f,
						MinSpeed = 0.0f,
						MaxSpeed = 1.00f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.02f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.5f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.02f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.5f,
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
						TurnSpeed = WAngle.FromDegrees(0.3f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.7f,
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
						TurnSpeed = WAngle.FromDegrees(0.3f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.7f,
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
						TurnSpeed = WAngle.FromDegrees(0.27f),
						Acceleration = 0.009f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.63f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.9f,
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
						TurnSpeed = WAngle.FromDegrees(0.5f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.9f,
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
						TurnSpeed = WAngle.FromDegrees(4.0f),
						Acceleration = 0.01f,
						MinSpeed = 0.5f,
						MaxSpeed = 2.35f,
						LandingDistance = 280.0f,
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
						TurnSpeed = WAngle.FromDegrees(2.2f),
						Acceleration = 0.01f,
						MinSpeed = 0.5f,
						MaxSpeed = 2.5f,
						LandingDistance = 280.0f,
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
						TurnSpeed = WAngle.FromDegrees(1.8f),
						Acceleration = 0.008f,
						MinSpeed = 0.5f,
						MaxSpeed = 2.35f,
						LandingDistance = 280.0f,
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
						TurnSpeed = WAngle.FromDegrees(2.0f),
						Acceleration = 0.02f,
						MinSpeed = 0.5f,
						MaxSpeed = 2.7f,
						LandingDistance = 280.0f,
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
						TurnSpeed = WAngle.FromDegrees(3.0f),
						Acceleration = 0.03f,
						MinSpeed = 0.5f,
						MaxSpeed = 3.0f,
						LandingDistance = 280.0f,
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
						TurnSpeed = WAngle.FromDegrees(3.0f),
						Acceleration = 0.01f,
						MinSpeed = 0.5f,
						MaxSpeed = 2.2f,
						LandingDistance = 280.0f,
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
						TurnSpeed = WAngle.FromDegrees(3.0f),
						Acceleration = 0.01f,
						MinSpeed = 0.5f,
						MaxSpeed = 2.2f,
						LandingDistance = 280.0f,
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
						TurnSpeed = WAngle.FromDegrees(2.4f),
						Acceleration = 0.005f,
						MinSpeed = 0.5f,
						MaxSpeed = 1.8f,
						LandingDistance = 560.0f,
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
						TurnSpeed = WAngle.FromDegrees(2.0f),
						Acceleration = 0.005f,
						MinSpeed = 0.5f,
						MaxSpeed = 1.9f,
						LandingDistance = 560.0f,
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
						TurnSpeed = WAngle.FromDegrees(0.3f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.65f,
					},
					new HealthOptions
					{
						MaxHP = 9,
					},
					new TransportOptions
					{
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
						TurnSpeed = WAngle.FromDegrees(0.3f),
						Acceleration = 0.01f,
						MinSpeed = 0.0f,
						MaxSpeed = 0.65f,
					},
					new HealthOptions
					{
						MaxHP = 9,
					},
					new TransportOptions
					{
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
