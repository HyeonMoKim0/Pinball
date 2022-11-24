using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GameObject score_object;
    BallController ball_Chance;
    //Text scorepoint;
    //Score scorescript;
    //int point;

    uint B_Score = 100;

    void Start()
    {
        score_object = GameObject.Find("Score");
        ball_Chance = GameObject.Find("Ball").GetComponent<BallController>();
        //B_DoubleChance = GameObject.Find("Ball").GetComponent<BallController>().doubleChance;
        //B_LifeChance = GameObject.Find("Ball").GetComponent<BallController>().lifeChance;
    }

    void Update()
    {
        score_object.GetComponent<Text>().text = GameManager.instance.Score.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.Score += B_Score;
        BallController.instance.doubleChance++;
        BallController.instance.lifeChance++;
        //B_DoubleChance++;
        //B_LifeChance++;
    }
}
