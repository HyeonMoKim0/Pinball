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

    public ushort doubleChance; //5의 배수마다 충돌시 점수 2배
    public ushort lifeChance; //Pointball에 15번마다 충돌할 경우 목숨 +1

    uint score_set = 100;   

    [SerializeField] float upspeed; //기본 300
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
            keydown = time;


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
            GameManager.instance.Lifecount--;

            doubleChance = 0;
            lifeChance = 0;
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
            run = true;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spring"))
            run = false;

        if (other.gameObject.CompareTag("Pointball"))
        {
            GameManager.instance.Score += score_set;
            doubleChance++;
            lifeChance++;

            if (doubleChance == 5)
            {
                GameManager.instance.Score += score_set;
                doubleChance = 0;
            }

            if (lifeChance == 15)
            {
                GameManager.instance.Lifecount++;
                if (GameManager.instance.Lifecount == 4)
                    GameManager.instance.Score += 3000;

                lifeChance = 0;
            }
        }
    }
}