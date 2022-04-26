using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerScript : MonoBehaviour
{
    //public MonsterStats[] monsterLibrary;
    public Transform MonsterSpawnPoint;
    public GameObject MonsterPrefab;

    //private List<MonsterStats> activeMonsters = new List<MonsterStats>();
    //public MonsterStats[] MonsterPrefabLibrary;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Instantiate(MonsterPrefab MonsterSpawnPoint.position, MonsterSpawnPoint.rotation);

            Instantiate(this.MonsterPrefab, this.MonsterSpawnPoint.position, MonsterSpawnPoint.rotation);
        }


        //this.InstantiateRandomCharactersOntoSpawnPositions(this.heroLibrary, this.heroSpawnPoints, this.activeHeroes, true)
        //this.InstantiateRandomCharactersOntoSpawnPositions(this.monsterLibrary, this.monsterSpawnPoints, this.activeMonsters, false)


        //Monster spawn
        //Randomise spawn between 2 monsters
        //Have trigger points for spawning
        //Play audio when spawning
    }
}