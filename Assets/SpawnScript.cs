﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] ballons;

    void Start()
    {
        StartCoroutine(StartSpawning());
    }
     IEnumerator StartSpawning(){
            yield return new WaitForSeconds(4);
            for(int i=0; i<3; i++){
                Instantiate(ballons[i], spawnPoints[i].position, Quaternion.identity);
            }
            StartCoroutine(StartSpawning());
        }
}

