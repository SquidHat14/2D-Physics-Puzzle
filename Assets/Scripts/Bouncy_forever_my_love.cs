using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy_forever_my_love : Platform
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            anim.SetTrigger("Made Contact");
        }
    }

    void OnDrawGizmos()
    {
            Gizmos.color = Color.cyan;
            float size = .3f;
           
                Vector3 globalWaypointPos = new Vector3(this.transform.position.x, this.transform.position.y, 0);
                Gizmos.DrawLine(globalWaypointPos + Vector3.up * 3, globalWaypointPos + Vector3.up * size);
    }


}
