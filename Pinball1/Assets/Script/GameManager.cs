using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] int _deathCount = 0;
    [SerializeField] int life_count = 3;

    public int DeathCount
    {
        get { return _deathCount; }
        set { _deathCount = value; }
    }

    public int Lifecount
    {
        get { return life_count; }
        set { life_count = value; }
    }

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(instance);
    }

    public void Telepote(GameObject ball, GameObject tpos) 
    {
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ball.transform.position = tpos.transform.position;
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (life_count == 0)
            SceneManager.LoadScene("GameScene");
    }
}
