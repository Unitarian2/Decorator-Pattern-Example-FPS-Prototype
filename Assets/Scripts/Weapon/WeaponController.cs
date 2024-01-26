using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour,IObserver
{
    [SerializeField] Subject _playerInteractionSubject;

    private void OnEnable()
    {
        _playerInteractionSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        _playerInteractionSubject.RemoveObserver(this);
    }

    public void OnNotify(StatType statType, float amount)
    {
        switch (statType)
        {    
            case StatType.Damage:
                Debug.LogWarning("Add Damage Modifier Here");
                break;
            case StatType.FireRate:
                Debug.LogWarning("Add Fire Rate Modifier Here");
                break;
        }
    }
}
