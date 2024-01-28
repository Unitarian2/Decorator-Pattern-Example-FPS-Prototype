using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletController : MonoBehaviour
{
    public bool isAlive;
    Vector3 moveDirection;
     Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        isAlive = true;
    }

    private void OnDisable()
    {
        isAlive = false;
    }

    public void StartMoving(Vector3 direction)
    {
        moveDirection = direction;
        //rb.AddForce(direction, ForceMode.Impulse);
    }

    private void Update()
    {
        transform.position += moveDirection * Time.deltaTime;
    }

}
