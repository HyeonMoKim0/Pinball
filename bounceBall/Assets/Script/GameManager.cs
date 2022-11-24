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
    bool isGameOver;
    bool isGameClear;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else if (instance != this) Destroy(gameObject);

        //DontDestroyOnLoad(instance);
    }
    void Start()
    {
        isGameOver = false;
        isGameClear = false;
    }

    public void Update()
    {
        
        if (isGameOver || isGameClear)
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
        isGameClear = true;
        gameclearText.SetActive(true);
    }
}