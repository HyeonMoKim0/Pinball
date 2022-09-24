using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;    GameManager∑Œ ø≈±Ë

public class Life : MonoBehaviour
{
    Text life;

    void Start()
    {
        life = GetComponent<Text>();
    }

    void Update()
    {
        life.text = "Life: " + GameManager.instance.Lifecount.ToString();

        if (GameManager.instance.Lifecount == 0)
        {
            GameManager.instance.DeathCount++;
            //SceneManager.LoadScene("GameScene");  GameManager¿« Updateø° ø≈±Ë 
        }
    }
}
