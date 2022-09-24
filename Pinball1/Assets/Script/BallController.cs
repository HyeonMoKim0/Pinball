using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Pin1Controller pin1;
    Pin2Controller pin2;
    Rigidbody2D rigid2D;
    Animation spring_anima;
    public GameObject startpos;

    public float upspeed;
    float time;
    float keydown;
    float keyup;
    bool run = true;

    void Start()
    {
        pin1 = GameObject.Find("Pin1").GetComponent<Pin1Controller>();
        pin2 = GameObject.Find("Pin2").GetComponent<Pin2Controller>();
        spring_anima = GameObject.Find("Spring").GetComponent<Animation>();
        rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.C))
        {
            keydown = time;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            keyup = time;
            if (run)
            {
                rigid2D.AddForce(transform.up * (500 * Mathf.Clamp(keyup - keydown, 2, 4.5f)));
                spring_anima.Play();
            }
        }

        if (transform.position.y < -6)
        {
            rigid2D.freezeRotation = true;
            transform.rotation = Quaternion.Euler(Vector3.zero);
            GameManager.instance.Telepote(GameObject.Find("Ball"), startpos);
            //GameManager의 Telepote 함수 사용 33줄
            //rigid2D.velocity = Vector2.zero;
            //transform.position = startpos.transform.position;
            GameManager.instance.Lifecount--;
            
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (pin1.anima.isPlaying)
        {
            if (other.gameObject.CompareTag("Pin"))
            {
                transform.rotation = Quaternion.Euler(Vector3.zero);
                rigid2D.AddForce(transform.up * upspeed);
            }
        }
        if (pin2.anima.isPlaying)
        {
            if (other.gameObject.CompareTag("Pin2"))
            {
                transform.rotation = Quaternion.Euler(Vector3.zero);
                rigid2D.AddForce(transform.up * upspeed);
            }
        }

        if (other.gameObject.CompareTag("Spring")) 
        {
            run = true; 
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spring"))
        {
            run = false;
        }
    }
}










//if (pincontroller.animator.GetCurrentAnimatorStateInfo(0).IsName("Move") && pincontroller.animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
//{
//    if (other.gameObject.CompareTag("Pin"))
//    {
//        rigid2D.AddForce(transform.up * upspeed);
//    }
//}

//else if (pincontroller.animator.GetCurrentAnimatorStateInfo(0).IsName("Move2") && pincontroller.animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
//{
//    if (other.gameObject.CompareTag("Pin2"))
//    {
//        rigid2D.AddForce(transform.up * upspeed);
//    }
//}