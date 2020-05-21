using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : Platform
{

    private CircleCollider2D magnetZone;
    public int magnetForce;


    void Awake()
    {
        magnetZone = GetComponent<CircleCollider2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {

            Vector2 direction = (transform.position - base.Ball.transform.position).normalized;
            float travelSpeed = Vector2.Distance(transform.position, base.Ball.transform.position);
            base.Ball.GetComponent<Rigidbody2D>().AddForce(-direction * travelSpeed * magnetForce * 1/Vector3.Distance(base.Ball.transform.position, this.transform.position));
        }
    }
} 