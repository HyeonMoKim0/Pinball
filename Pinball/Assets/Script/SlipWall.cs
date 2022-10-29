using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlipWall : MonoBehaviour
{
    GameObject player;

    Rigidbody2D p_Rigid;

    void Start()
    {
        player = GameObject.Find("Ball");
        p_Rigid = player.GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
            p_Rigid.velocity = new Vector2(0, 0);
    }
}