using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private Animator anim1;
    private Animator anim2;

    BoxCollider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        collide = GetComponent<BoxCollider2D>();
        anim1 = GameObject.FindGameObjectsWithTag("Ball_in")[0].GetComponent<Animator>();
        anim2 = GameObject.FindGameObjectsWithTag("Next_Level")[0].GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Do something to the "owning" component
        Debug.Log("hit goal");
        anim1.SetTrigger("goal");
        anim2.SetTrigger("goal");

        ScoreManager.instance.addScore(99);
    }
}
