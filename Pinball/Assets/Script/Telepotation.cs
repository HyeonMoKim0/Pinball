using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telepotation : MonoBehaviour
{
    public GameObject tpos;
    GameObject player;

    public Vector2 boost;

    Rigidbody2D ball_rigid2d;

    void Start()
    {
        player = GameObject.Find("Ball");
        ball_rigid2d = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            GameManager.instance.Telepote(player, tpos);
            ball_rigid2d.velocity = boost;
        }
        
    }
}