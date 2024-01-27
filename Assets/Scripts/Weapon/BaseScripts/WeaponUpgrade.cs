using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrade : IWeaponUpgrade
{
    readonly float value;
    

    public WeaponUpgrade(float value)
    {
        this.value = value;
    }

    public float GetModifier()
    {
        return value;
    }
}
