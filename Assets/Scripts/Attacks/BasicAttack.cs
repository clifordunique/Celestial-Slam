﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Basic Attack", menuName = "Attacks/Basic")]
public class BasicAttack : ScriptableObject
{
    public string attackName;
    public string animationName;
    public float damagePower;
    public float priorityPower;
    public Vector2 knockback;
    public float GuardBreaking;
    public bool chargable;
    public bool delay;
    public bool flinchless;
    public float recharge = 0.5f;
    public float gripLoss;
    public GameObject projectile;

}
