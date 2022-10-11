using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameoverText;
    public GameObject gameclearText;
    private bool isGameOver;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(instance);
    }
    void Start()
    {
        isGameOver = false;    
    }

    public void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Level_1");
            }
        }
    } 
    
    public void GameOver()
    {
        isGameOver = true;
        gameoverText.SetActive(true);
    }

    public void GameClear()
    {
        gameclearText.SetActive(true);
    }
}