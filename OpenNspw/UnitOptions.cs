using OpenNspw.Components;

namespace OpenNspw;

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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.7f,
					HitBoxSize = 16,
				},
				new ArmamentOptions
				{
					MaxAmmo = 1000,
				},
				new GunshipOptions
				{
					Interval = 5,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 40,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.7f,
					HitBoxSize = 16,
				},
				new ArmamentOptions
				{
					MaxAmmo = 1000,
				},
				new GunshipOptions
				{
					Interval = 5,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 40,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.27f),
					Acceleration = 0.009f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.63f,
					HitBoxSize = 16,
				},
				new ArmamentOptions
				{
					MaxAmmo = 1350,
				},
				new GunshipOptions
				{
					Interval = 4,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 56,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.8f,
					HitBoxSize = 12,
				},
				new ArmamentOptions
				{
					MaxAmmo = 600,
				},
				new GunshipOptions
				{
					Interval = 10,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 32,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.8f,
					HitBoxSize = 12,
				},
				new ArmamentOptions
				{
					MaxAmmo = 600,
				},
				new GunshipOptions
				{
					Interval = 10,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 32,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.8f,
					HitBoxSize = 12,
				},
				new ArmamentOptions
				{
					MaxAmmo = 450,
				},
				new GunshipOptions
				{
					Interval = 10,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 25,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.8f,
					HitBoxSize = 12,
				},
				new ArmamentOptions
				{
					MaxAmmo = 450,
				},
				new GunshipOptions
				{
					Interval = 10,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 28,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(1.3f),
					Acceleration = 0.05f,
					MinSpeed = 0.0f,
					MaxSpeed = 1.00f,
					HitBoxSize = 10,
				},
				new ArmamentOptions
				{
					MaxAmmo = 120,
				},
				new GunshipOptions
				{
					Interval = 15,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 18,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(1.3f),
					Acceleration = 0.05f,
					MinSpeed = 0.0f,
					MaxSpeed = 1.00f,
					HitBoxSize = 10,
				},
				new ArmamentOptions
				{
					MaxAmmo = 120,
				},
				new GunshipOptions
				{
					Interval = 15,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 18,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(1.3f),
					Acceleration = 0.05f,
					MinSpeed = 0.0f,
					MaxSpeed = 1.00f,
					HitBoxSize = 10,
				},
				new ArmamentOptions
				{
					MaxAmmo = 120,
				},
				new GunshipOptions
				{
					Interval = 20,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 12,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(1.3f),
					Acceleration = 0.05f,
					MinSpeed = 0.0f,
					MaxSpeed = 1.00f,
					HitBoxSize = 10,
				},
				new ArmamentOptions
				{
					MaxAmmo = 120,
				},
				new GunshipOptions
				{
					Interval = 20,
					Sound = "aa_blt3",
				},
				new HealthOptions
				{
					MaxHP = 16,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.02f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.5f,
					HitBoxSize = 8,
				},
				new ArmamentOptions
				{
					MaxAmmo = 25,
				},
				new SubmarineOptions(),
				new HealthOptions
				{
					MaxHP = 7,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.02f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.5f,
					HitBoxSize = 8,
				},
				new ArmamentOptions
				{
					MaxAmmo = 25,
				},
				new SubmarineOptions(),
				new HealthOptions
				{
					MaxHP = 7,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.7f,
					HitBoxSize = 14,
				},
				new ArmamentOptions
				{
					MaxAmmo = 100,
				},
				new GunshipOptions
				{
					Interval = 15,
					Sound = "aa_blt3",
				},
				new HangarOptions
				{
					Capacity = 12,
					Offset = 25,
					Types = { "CarrierBasedAircraft" },
				},
				new HealthOptions
				{
					MaxHP = 32,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.7f,
					HitBoxSize = 14,
				},
				new ArmamentOptions
				{
					MaxAmmo = 100,
				},
				new GunshipOptions
				{
					Interval = 15,
					Sound = "aa_blt3",
				},
				new HangarOptions
				{
					Capacity = 12,
					Offset = 25,
					Types = { "CarrierBasedAircraft" },
				},
				new HealthOptions
				{
					MaxHP = 37,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.27f),
					Acceleration = 0.009f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.63f,
					HitBoxSize = 14,
				},
				new ArmamentOptions
				{
					MaxAmmo = 110,
				},
				new GunshipOptions
				{
					Interval = 15,
					Sound = "aa_blt3",
				},
				new HangarOptions
				{
					Capacity = 14,
					Offset = 25,
					Types = { "CarrierBasedAircraft" },
				},
				new HealthOptions
				{
					MaxHP = 42,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.9f,
					HitBoxSize = 12,
				},
				new ArmamentOptions
				{
					MaxAmmo = 80,
				},
				new GunshipOptions
				{
					Interval = 20,
					Sound = "aa_blt3",
				},
				new HangarOptions
				{
					Capacity = 8,
					Offset = 25,
					Types = { "CarrierBasedAircraft" },
				},
				new HealthOptions
				{
					MaxHP = 27,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.5f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.9f,
					HitBoxSize = 12,
				},
				new ArmamentOptions
				{
					MaxAmmo = 80,
				},
				new GunshipOptions
				{
					Interval = 20,
					Sound = "aa_blt3",
				},
				new HangarOptions
				{
					Capacity = 8,
					Offset = 25,
					Types = { "CarrierBasedAircraft" },
				},
				new HealthOptions
				{
					MaxHP = 32,
				},
				new DrawUnitOptions(),
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
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(4.0f),
					Acceleration = 0.01f,
					MinSpeed = 0.5f,
					MaxSpeed = 2.35f,
					LandingDistance = 280.0f,
					HangarType = "CarrierBasedAircraft",
				},
				new ArmamentOptions
				{
					MaxAmmo = 35,
					RequiresCondition = new("!hangar"),
				},
				new WingGunOptions
				{
					Interval = 10,
					Sound = "aa_blt1",
				},
				new HealthOptions
				{
					MaxHP = 14,
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("!folded"),
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("folded"),
					Texture = "ft_jpn_folded",
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
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(2.2f),
					Acceleration = 0.01f,
					MinSpeed = 0.5f,
					MaxSpeed = 2.5f,
					LandingDistance = 280.0f,
					HangarType = "CarrierBasedAircraft",
				},
				new ArmamentOptions
				{
					MaxAmmo = 40,
					RequiresCondition = new("!hangar"),
				},
				new WingGunOptions
				{
					Interval = 10,
					Sound = "aa_blt2",
				},
				new HealthOptions
				{
					MaxHP = 18,
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("!folded"),
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("folded"),
					Texture = "ft_usa_folded",
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
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(1.8f),
					Acceleration = 0.008f,
					MinSpeed = 0.5f,
					MaxSpeed = 2.35f,
					LandingDistance = 280.0f,
					HangarType = "LandBasedAircraft",
				},
				new ArmamentOptions
				{
					MaxAmmo = 50,
					RequiresCondition = new("!hangar"),
				},
				new WingGunOptions
				{
					Interval = 7,
					Sound = "aa_shl4",
				},
				new HealthOptions
				{
					MaxHP = 11,
				},
				new DrawUnitOptions(),
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
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(2.0f),
					Acceleration = 0.02f,
					MinSpeed = 0.5f,
					MaxSpeed = 2.7f,
					LandingDistance = 280.0f,
					HangarType = "LandBasedAircraft",
				},
				new ArmamentOptions
				{
					MaxAmmo = 60,
					RequiresCondition = new("!hangar"),
				},
				new WingGunOptions
				{
					Interval = 7,
					Sound = "aa_shl4",
				},
				new HealthOptions
				{
					MaxHP = 28,
				},
				new DrawUnitOptions(),
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
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(3.0f),
					Acceleration = 0.03f,
					MinSpeed = 0.5f,
					MaxSpeed = 3.0f,
					LandingDistance = 280.0f,
					HangarType = "LandBasedAircraft",
				},
				new ArmamentOptions
				{
					MaxAmmo = 60,
					RequiresCondition = new("!hangar"),
				},
				new WingGunOptions
				{
					Interval = 7,
					Sound = "aa_shl4",
				},
				new HealthOptions
				{
					MaxHP = 32,
				},
				new DrawUnitOptions(),
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
				new BomberOptions(),
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(3.0f),
					Acceleration = 0.01f,
					MinSpeed = 0.5f,
					MaxSpeed = 2.2f,
					LandingDistance = 280.0f,
					HangarType = "CarrierBasedAircraft",
					Weapons = AirplaneWeapons.Bomb | AirplaneWeapons.Torpedo,
				},
				new ArmamentOptions
				{
					MaxAmmo = 1,
					RequiresCondition = new("!hangar"),
				},
				new TailGunnerOptions
				{
					Interval = 35,
					Sound = "aa_blt3",
				},
				new BombingOptions
				{
					BombingMethod = BombingMethod.Horizontal,
				},
				new TorpedoBombingOptions(),
				new HealthOptions
				{
					MaxHP = 16,
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("!folded"),
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("folded"),
					Texture = "at_jpn_folded",
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
				new BomberOptions(),
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(3.0f),
					Acceleration = 0.01f,
					MinSpeed = 0.5f,
					MaxSpeed = 2.2f,
					LandingDistance = 280.0f,
					HangarType = "CarrierBasedAircraft",
					Weapons = AirplaneWeapons.Bomb | AirplaneWeapons.Torpedo,
				},
				new ArmamentOptions
				{
					MaxAmmo = 1,
					RequiresCondition = new("!hangar"),
				},
				new TailGunnerOptions
				{
					Interval = 35,
					Sound = "aa_blt3",
				},
				new BombingOptions
				{
					BombingMethod = BombingMethod.Dive,
				},
				new TorpedoBombingOptions(),
				new HealthOptions
				{
					MaxHP = 20,
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("!folded"),
				},
				new DrawUnitOptions
				{
					RequiresCondition = new("folded"),
					Texture = "at_usa_folded",
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
				new BomberOptions(),
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(2.4f),
					Acceleration = 0.005f,
					MinSpeed = 0.5f,
					MaxSpeed = 1.8f,
					LandingDistance = 560.0f,
					HangarType = "LandBasedAircraft",
					Weapons = AirplaneWeapons.Bomb | AirplaneWeapons.Torpedo,
				},
				new ArmamentOptions
				{
					MaxAmmo = 9,
					RequiresCondition = new("!hangar"),
				},
				new GunshipOptions
				{
					Interval = 20,
					Sound = "aa_blt4",
				},
				new CarpetBombingOptions
				{
					Interval = 5,
				},
				new TorpedoBombingOptions(),
				new HealthOptions
				{
					MaxHP = 32,
				},
				new DrawUnitOptions(),
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
				new BomberOptions(),
				new ReturnToBaseOptions(),
				new LeaderOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new FollowerOptions
				{
					PauseOnCondition = new("hangar"),
				},
				new AirplaneOptions
				{
					TurnSpeed = WAngle.FromDegrees(2.0f),
					Acceleration = 0.005f,
					MinSpeed = 0.5f,
					MaxSpeed = 1.9f,
					LandingDistance = 560.0f,
					HangarType = "LandBasedAircraft",
					Weapons = AirplaneWeapons.Bomb,
				},
				new ArmamentOptions
				{
					MaxAmmo = 20,
					RequiresCondition = new("!hangar"),
				},
				new GunshipOptions
				{
					Interval = 20,
					Sound = "aa_blt4",
				},
				new CarpetBombingOptions
				{
					Interval = 5,
				},
				new HealthOptions
				{
					MaxHP = 50,
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
				},
				new DrawUnitOptions(),
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
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
				},
				new DrawUnitOptions(),
			}
		},
		{
			"tr_sp_jpn",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Military Port)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "sp_jpn",
				},
				new DrawUnitOptions
				{
					Texture = "tr_jpn",
				},
			}
		},
		{
			"tr_sp_usa",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Military Port)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "sp_usa",
				},
				new DrawUnitOptions
				{
					Texture = "tr_usa",
				},
			}
		},
		{
			"tr_ap_jpn",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Airfield)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "ap_jpn",
				},
				new DrawUnitOptions
				{
					Texture = "tr_jpn",
				},
			}
		},
		{
			"tr_ap_usa",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Airfield)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "ap_usa",
				},
				new DrawUnitOptions
				{
					Texture = "tr_usa",
				},
			}
		},
		{
			"tr_gf1_jpn",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Trench)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "gf1_jpn",
				},
				new DrawUnitOptions
				{
					Texture = "tr_jpn",
				},
			}
		},
		{
			"tr_gf1_usa",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Trench)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "gf1_usa",
				},
				new DrawUnitOptions
				{
					Texture = "tr_usa",
				},
			}
		},
		{
			"tr_gf2_jpn",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Pillbox)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "gf2_jpn",
				},
				new DrawUnitOptions
				{
					Texture = "tr_jpn",
				},
			}
		},
		{
			"tr_gf2_usa",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Pillbox)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "gf2_usa",
				},
				new DrawUnitOptions
				{
					Texture = "tr_usa",
				},
			}
		},
		{
			"tr_gf3_jpn",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Fortress)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "gf3_jpn",
				},
				new DrawUnitOptions
				{
					Texture = "tr_jpn",
				},
			}
		},
		{
			"tr_gf3_usa",
			new IComponentOptions[]
			{
				new TooltipOptions
				{
					Name = "Transport (Fortress)",
				},
				new LeaderOptions(),
				new FollowerOptions(),
				new ShipOptions
				{
					TurnSpeed = WAngle.FromDegrees(0.3f),
					Acceleration = 0.01f,
					MinSpeed = 0.0f,
					MaxSpeed = 0.65f,
					HitBoxSize = 12,
				},
				new LandingOperationOptions
				{
					Sound = "spl1",
				},
				new HealthOptions
				{
					MaxHP = 9,
				},
				new TransportOptions
				{
					Unit = "gf3_usa",
				},
				new DrawUnitOptions
				{
					Texture = "tr_usa",
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
					Types = { "CarrierBasedAircraft", "LandBasedAircraft" },
				},
				new HealthOptions
				{
					MaxHP = 260,
				},
				new DrawUnitOptions(),
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
					Types = { "CarrierBasedAircraft", "LandBasedAircraft" },
				},
				new HealthOptions
				{
					MaxHP = 260,
				},
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
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
				new DrawUnitOptions(),
			}
		},
	};
}
