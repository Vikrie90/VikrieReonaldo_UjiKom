using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.Rendering;

public class AnimalMovement : MonoBehaviour
{
    public GameObject AnimalPrefab;
    public GameObject Direction;
    public float Speed;

    void Update()
    {
        AnimalPrefab.transform.position = Vector3.MoveTowards(AnimalPrefab.transform.position,Direction.transform.position,Speed);
    }

}
