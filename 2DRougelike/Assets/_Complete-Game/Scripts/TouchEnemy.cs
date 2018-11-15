using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEnemy : MonoBehaviour
{
    GameObject[] enemy;
    public float timer;
    float tim ;
    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        tim = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

        foreach(var a in enemy)
        {
            if (!a.activeSelf)
            {
                tim += Time.deltaTime;
                if (timer <= tim)
                {
                    a.SetActive(true);
                    tim = 0.0f;
                }
            }
        }
    }
}
