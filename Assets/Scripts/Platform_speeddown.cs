using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_speeddown : Platform
{
    public float minSpeed = 2.5f;
    private GameObject Ball;
    private Rigidbody2D rb;

    void Start()
    {
        Ball = GameObject.FindGameObjectsWithTag("Ball")[0];
        rb = Ball.GetComponent<Rigidbody2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            if (rb.velocity.x > minSpeed || rb.velocity.x < -1 * minSpeed)
            {
                Vector2 temp = new Vector2(rb.velocity.x - (.5f * Mathf.Sign(rb.velocity.x)), rb.velocity.y);
                rb.velocity = temp;
            }
        }
    }
}
