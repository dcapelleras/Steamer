using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pips : MonoBehaviour
{
    Transform[] tuberias;
    public float velocidad = 2f;

    void Start()
    {
        tuberias = GetComponentsInChildren<Transform>();
    }


    void Update()
    {
        for (int i = 0; i < tuberias.Length; i++)
        {
            transform.Translate(-tuberias[i].right * Time.deltaTime * velocidad);
        }
    }
}
