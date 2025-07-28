﻿using Robust.Shared.GameStates;
using Robust.Shared.Map;

namespace Content.Shared._MC.Stun;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class MCStunOnHitComponent : Component
{
    [DataField, AutoNetworkedField]
    public MapCoordinates? ShotFrom;

    [DataField, AutoNetworkedField]
    public float MaxDistance = 5;

    [DataField, AutoNetworkedField]
    public TimeSpan StunTime = TimeSpan.Zero;

    [DataField, AutoNetworkedField]
    public TimeSpan ParalyzeTime = TimeSpan.Zero;

    [DataField, AutoNetworkedField]
    public TimeSpan StaggerTime = TimeSpan.Zero;

    [DataField, AutoNetworkedField]
    public TimeSpan SlowdownTime = TimeSpan.Zero;

    [DataField, AutoNetworkedField]
    public float Knockback = 1;

    [DataField, AutoNetworkedField]
    public float KnockbackSpeed = 10;
}
