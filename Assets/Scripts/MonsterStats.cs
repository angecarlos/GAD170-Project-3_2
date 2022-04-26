using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStats : MonoBehaviour
{
    [Header("Health")]
    public int health;
    public float currentHealth;

    [Header("Damage")]
    public int damage;

    private void Start()
    {
        SetCurrentHealth();

    }

    void SetCurrentHealth()
    {
        currentHealth = health;
        Debug.Log("currentHealth = " + currentHealth);
    }

   
    void Update()
    {

    }

    void TakeDamage(int damageAmount)

    {
        this.currentHealth -= damageAmount;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }

    }

    // HACK to fix playing audio incase about to destroy character (Otherwise should use this.GetComponent<AudioSource>().Play())
    //AudioSource.PlayClipAtPoint(this.GetComponent<AudioSource>().clip, Camera.main.transform.position);

    //this.GetComponent<SpriteRenderer>().color = Color.red;
    //Invoke("StopDamage", 0.2f);

    //}

    //void StopDamage()
    //{
    //this.GetComponent<SpriteRenderer>().color = Color.white;

    // Added this for health bar but not working//
    //_Heal
}