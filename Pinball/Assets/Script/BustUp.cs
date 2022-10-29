using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BustUp : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rigid;

    //Quaternion p_Rotation;

    //float x;
    //float y;
    //float z;

    Rigidbody2D setrigid;

    void Start()
    {
        player = GameObject.Find("Ball");
        rigid = player.GetComponent<Rigidbody2D>();
        setrigid = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            setrigid.velocity = rigid.velocity;
            rigid.velocity *= new Vector3(-1, -1, -1);
            //p_Rotation = player.transform.rotation;
            //x = p_Rotation.x;
            //y = p_Rotation.y;
            //z = p_Rotation.z;

            //player.transform.rotation = Quaternion.Euler(-x, -y, -z);
            //print("aa");
            
            //player.transform.rotation = 

            //rigid.velocity = new Vector2(0, 0);
            //rigid.AddForce(new Vector2(7, 10), ForceMode2D.Impulse);
        }
    }

    //void OnCollisionStay(Collision collision)
    //{

    //    rigid.velocity = new Vector2(0, 0);

    //    //rigid.AddForce(new Vector2(100, 100), ForceMode2D.Impulse);

    //    //if (collision.gameObject == player)
    //    //{

    //    //}
    //}



}
