using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponUpgrader : IWeaponUpgrade
{
    protected IWeaponUpgrade weaponUpgrade;
    protected readonly float value;
    

    protected WeaponUpgrader(float value)
    {
        this.value = value;
        
    }
    public virtual float GetModifier()
    {
        return weaponUpgrade?.GetModifier() + value ?? value;
    }

    public void Upgrade(IWeaponUpgrade weaponUpgrade)
    {
        this.weaponUpgrade = weaponUpgrade;
    }
}
