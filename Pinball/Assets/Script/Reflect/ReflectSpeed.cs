using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectSpeed : MonoBehaviour
{
    GameObject player;
    Rigidbody2D p_Rigid;

    Rigidbody2D setrigid;

    uint B_Score;
    ushort B_DoubleChance;
    ushort B_LifeChance;

    void Start()
    {
        player = GameObject.Find("Ball");

        p_Rigid = player.GetComponent<Rigidbody2D>();
        setrigid = GetComponent<Rigidbody2D>();

        B_DoubleChance = player.GetComponent<BallController>().doubleChance;
        B_LifeChance = player.GetComponent<BallController>().lifeChance;
        B_Score = player.GetComponent<BallController>().score_set;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            setrigid.velocity = p_Rigid.velocity;
            p_Rigid.velocity *= new Vector3(2, -1, 1);

            GameManager.instance.Score += B_Score;
            B_DoubleChance++;
            B_LifeChance++;
        }
    }
}