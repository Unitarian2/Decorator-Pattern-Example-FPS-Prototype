using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletController : MonoBehaviour
{
    public bool isAlive;
    Vector3 moveDirection;
    public float moveSpeed;

    private void Awake()
    {
        
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
    }

    private void Update()
    {
        if (isAlive)
        {
            transform.position += moveDirection * Time.deltaTime * moveSpeed;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.LogError("Collided : "+ collision.collider.gameObject.name);
        
        Destroy(gameObject);
    }

}
