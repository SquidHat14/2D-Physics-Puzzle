using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_speedup : Platform
{
    public float speedup;
    
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("test");
            Ball.GetComponent<Rigidbody2D>().AddForce(transform.right * speedup);
        }
    }
}
