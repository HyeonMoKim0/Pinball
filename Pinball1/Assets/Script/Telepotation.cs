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
        //GameManager의 Telepote 함수 사용 33줄
        //ball_rigid2d.velocity = Vector2.zero;
        //ball_rigid2d.transform.position = tpos.transform.position;

        ball_rigid2d.velocity = boost;
    }
}
