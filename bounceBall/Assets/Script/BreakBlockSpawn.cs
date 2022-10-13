using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlockSpawn : MonoBehaviour
{
    public GameObject[] b = new GameObject[3];
    double[] t = new double[3];
    public bool timestart;

    void Start()
    {
        for (int i = 0; i < 3; i++)
            b[i] = transform.GetChild(i).gameObject;
    }

    void Update()
    {
        BlockSpawn(0);
        BlockSpawn(1);
        BlockSpawn(2);
    }
    void BlockSpawn(int a)
    {
        if (b[a].activeSelf == false)
        {
            if (timestart)
            {
                t[a] += Time.deltaTime;
                if (t[a] > 3)
                {
                    t[a] = 0;
                    b[a].SetActive(true);
                }
            }
        }
    }
}
