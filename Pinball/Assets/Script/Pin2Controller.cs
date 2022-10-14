using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin2Controller : MonoBehaviour
{
    public Animation anima;

    void Start()
    {
        anima = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            anima.Play();
    }
}