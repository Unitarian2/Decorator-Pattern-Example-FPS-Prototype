using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WDamageUpgrade : WeaponDecorator
{
    WeaponController controller;
    WeaponUpgradeDefinition upgrade;
    public WDamageUpgrade(IWeapon decoratedWeapon, WeaponController controller, WeaponUpgradeDefinition upgrade) : base(decoratedWeapon)
    {
        this.controller = controller;
        this.upgrade = upgrade;
    }

    public override void Fire()
    {
        controller.currentWeaponDamage += upgrade.value;
        base.Fire();
        
        Debug.Log("Damage upgraded!");
    }
}
