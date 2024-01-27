using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWeapon : IWeapon
{


    public void Fire()
    {
        Debug.Log("Basic shooting!");
    }
}
