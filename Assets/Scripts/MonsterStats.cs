using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterStats : MonoBehaviour
{
    public PlayerStats Script;

    [Header("Monster Health")]
    public int MonsterHealth = 10;
    public float currentMonsterHealth;

    [Header("Monster Damage")]
    public int MonsterDamage = 2;

    private void Start()
    {
        SetCurrentMonsterHealth();

    }

    void SetCurrentMonsterHealth()
    {
        currentMonsterHealth = MonsterHealth;
        Debug.Log("currentHealth = " + currentMonsterHealth);

        //currentPlayerHealth = (maxPlayerHealth * level);
        //Debug.Log("currentHealth = " + currentPlayerHealth);
    }

   
    void Update()
    {
        
    }

    public void TakeDamage(int currentPlayerMagicDamage)
    //public void TakeDamage(int currentPlayerDamage, int currentPlayerMagicDamage)
    {
        this.currentMonsterHealth -= currentPlayerMagicDamage;

        if (currentMonsterHealth <= 0)
            Destroy(this.gameObject);

    }

    //private void Die()
    //{
    //    gameObject.Destroy
    //}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerStats>().TakeDamage(MonsterDamage);

        }
    }

}