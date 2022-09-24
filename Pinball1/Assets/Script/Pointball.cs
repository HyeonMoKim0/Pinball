using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointball : MonoBehaviour
{
    Score scorescript;

    void Start()
    {
        scorescript = GameObject.Find("Score").GetComponent<Score>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        scorescript.point++;
    }
}
