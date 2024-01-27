using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecklessDamageUpgrade : WeaponUpgrader
{
    PlayerMovement playerMovement;
    public RecklessDamageUpgrade(float value, PlayerMovement playerMovement) : base(value)
    {
        this.playerMovement = playerMovement;  
    }

    public override float GetModifier()
    {
        playerMovement.IncreaseMovementModifier(0.1f);
        return weaponUpgrade?.GetModifier() + value ?? value;
    }

   
}
