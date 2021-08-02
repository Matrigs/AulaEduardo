using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public CircleCollider2D checkcollider;


    void Start()
    {
        checkcollider = gameObject.GetComponent<CircleCollider2D>();


    }

   
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.GetComponent<Collider2D>().tag=="Player")
        {
            checkcollider.enabled = false;

        }


    }
}
