using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text score_object;
    BallController ball_Chance;

    //uint score_set = 100;

    void Start()
    {
        score_object = GameObject.Find("Score").GetComponent<Text>();
        ball_Chance = GameObject.Find("Ball").GetComponent<BallController>();
    }

    void Update()
    {
        score_object.text = GameManager.instance.Score.ToString();
    }

    void OnCollisionExit2D(Collision2D other)
    {
        //GameManager.instance.Score += score_set;
        //ball_Chance.doubleChance++;
        //ball_Chance.lifeChance++;

        //if (ball_Chance.doubleChance == 5)
        //{
        //    GameManager.instance.Score += score_set;
        //    ball_Chance.doubleChance = 0;
        //}

        //if (ball_Chance.lifeChance == 15)
        //{
        //    GameManager.instance.Lifecount++;
        //    if (GameManager.instance.Lifecount == 4)
        //        GameManager.instance.Score += 3000;

        //    ball_Chance.lifeChance = 0;
        //}

    }
}