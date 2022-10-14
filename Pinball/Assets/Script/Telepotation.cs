using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telepotation : MonoBehaviour
{
    public GameObject tpos;

    public Vector2 boost;

    Rigidbody2D ball_rigid2d;

    void Start()
    {
        ball_rigid2d = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.Telepote(GameObject.Find("Ball"), tpos);

        ball_rigid2d.velocity = boost;
    }
}