using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    [SerializeField] PlayerMovement playerMovement;

    public IWeaponUpgrade currentWeaponUpgrade;
    [SerializeField] WeaponUpgradeDefinition weaponUpgradeDefinition;
    [SerializeField] WeaponUpgradeDefinition weaponUpgradeDefinitionDamage;
    [SerializeField] WeaponUpgradeDefinition weaponUpgradeDefinitionRecklessDamage;
    public float weaponDamage;

    public float currentWeaponDamage;
    public float currentWeaponRateOfFire;
    IWeapon basicWeapon;


    private void Awake()
    {
        currentWeaponUpgrade = WeaponUpgradeFactory.Create(weaponUpgradeDefinition, playerMovement);
        basicWeapon = new BasicWeapon();
    }
    private void OnEnable()
    {
        ReceiveInteraction.OnWeaponUpgradePickedUp += ReceiveInteraction_OnWeaponUpgradePickedUp;
    }

    private void OnDisable()
    {
        ReceiveInteraction.OnWeaponUpgradePickedUp -= ReceiveInteraction_OnWeaponUpgradePickedUp;
    }

    private void ReceiveInteraction_OnWeaponUpgradePickedUp(WeaponUpgradeDefinition definition)
    {
        switch (definition.type)
        {
            case WeaponUpgradeType.Damage:

                // Hasar yükseltmesi eklenmiþ silah
                IWeapon weaponWithDamageUpgrade = new WDamageUpgrade(basicWeapon, this, definition);
                basicWeapon = weaponWithDamageUpgrade;

                //IWeaponUpgrade newUpgrade = WeaponUpgradeFactory.Create(definition, null);
                //if (newUpgrade is WeaponUpgrader upgrader)
                //{
                //    upgrader.Upgrade(currentWeaponUpgrade);
                //    currentWeaponUpgrade = upgrader;
                //}
                break;
            case WeaponUpgradeType.RecklessDamage:
                IWeapon weaponWithRateOfFireUpgrade = new WRateOfFireUpgrade(basicWeapon, this, definition);
                basicWeapon = weaponWithRateOfFireUpgrade;

                //IWeaponUpgrade newUpgrade2 = WeaponUpgradeFactory.Create(definition, playerMovement);
                //if (newUpgrade2 is WeaponUpgrader upgrader2)
                //{
                //    upgrader2.Upgrade(currentWeaponUpgrade);
                //    currentWeaponUpgrade = upgrader2;
                //}
                break;
        }

        //weaponDamage = currentWeaponUpgrade.GetModifier();

        // Oluþturulan temel silah
        

        

    }

    void FireWeapon()
    {
        currentWeaponDamage = 0f;
        currentWeaponRateOfFire = 0f;
        basicWeapon.Fire();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) FireWeapon();

    }
}
