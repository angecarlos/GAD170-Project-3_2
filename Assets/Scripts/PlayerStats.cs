using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Level of the player
    [Header("Level")]
    public int level = 1;

    [Header("Health")]
    public int maxHealth = 10;
    public float currentHealth;

    [Header("XP")]
    public int XP = 0;
    //public float currentXP;
    public float xpForNextLevel = 20;   //Xp needed to level up, the higher the level, the harder it gets.

    [Header("Damage")]
    public int damage = 2;
    public float currentDamage;


    private void Start()
    {
        SetCurrentHealth();
        //SetCurrentXP();
        SetXPForNextLevel();
        SetCurrentDamage();

    }

    void SetCurrentHealth()
    {
        currentHealth = (maxHealth * level);
        Debug.Log("currentHealth = " + currentHealth);
    }

    //void SetCurrentXP()
    //{
    //    currentXP = XP;
    //    Debug.Log("currentXP = " + currentXP);
    //}

    void SetXPForNextLevel()
    {
        xpForNextLevel = (20f + (level * level * 20f));
        Debug.Log("xpForNextLevel " + xpForNextLevel);
    }

    public void SetCurrentDamage()
    {
        currentDamage = (damage * level);
        Debug.Log("currentDamage = " + currentDamage);

        GameEvents.OnPlayerAttack?.Invoke((int)currentDamage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageAmount)

    {
        this.currentHealth -= damageAmount;
    }
}


//Player
//HP
//Add XP and HP would go up when XP gets to a certain point
//