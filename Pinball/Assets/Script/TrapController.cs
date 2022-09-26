using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{    
    private Collider2D collide;

    void Start()
    {
        collide = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            collide.isTrigger = true;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        collide.isTrigger = false;
        other.gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
    }
}
