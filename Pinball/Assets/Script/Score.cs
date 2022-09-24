using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GameObject score_object;
    //Text scorepoint;
    //Score scorescript;
    //int point;

    void Start()
    {
        score_object = GameObject.Find("Score");
        //scoretext = GameObject.Find("Score").GetComponent<text>();
        //scorescript = GameObject.Find("Score").GetComponent<Score>();
    }

    void Update()
    {
        score_object.GetComponent<Text>().text = GameManager.instance.Score.ToString();
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        //score_object.GetComponent<Score>().point++;
        GameManager.instance.Score++;
    }
}
