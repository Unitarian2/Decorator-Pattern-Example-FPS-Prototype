using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BasicWeapon : IWeapon
{
    private GameObject bulletPrefab;
    private WeaponController controller;
    public BasicWeapon(WeaponController controller) 
    {
        bulletPrefab = Resources.Load("Bullet") as GameObject;
        this.controller = controller;
    }

    public void Fire(Vector3 attackDirection)
    {
        Debug.Log("Basic shooting!");
        GameObject bullet = Object.Instantiate(bulletPrefab, controller.GetWeaponBarrelExitPoint(), Quaternion.identity);
        bullet.transform.forward = attackDirection.normalized;
        bullet.GetComponent<BulletController>().StartMoving(attackDirection.normalized);
    }
}
