using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerScript : MonoBehaviour
{
    //public MonsterStats[] monsterLibrary;
    public Transform MonsterSpawnPoint;
    public GameObject MonsterPrefab;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Instantiate(MonsterPrefab MonsterSpawnPoint.position, MonsterSpawnPoint.rotation);

            Instantiate(this.MonsterPrefab, this.MonsterSpawnPoint.position, MonsterSpawnPoint.rotation);
        }
    }
}