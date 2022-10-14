using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin1Controller : MonoBehaviour
{
    public Animation anima;

    void Start()
    {
        anima = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            anima.Play();
    }
}