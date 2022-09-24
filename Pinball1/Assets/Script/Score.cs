using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scorepoint;
    public int point;

    void Start()
    {
        scorepoint = GetComponent<Text>();
    }

    void Update()
    {
        scorepoint.text = point.ToString();
    }
}
