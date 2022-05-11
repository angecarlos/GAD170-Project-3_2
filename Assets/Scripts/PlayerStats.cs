using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public MonsterStats Script;
    public GameObject Magic;

    // Level of the player
    [Header("Level")]
    public int level = 1;

    [Header("Player Health")]
    public int maxPlayerHealth = 10;
    public float currentPlayerHealth;

    [Header("Player XP")]
    public int XP = 0;
    //public float currentXP;
    public float xpForNextLevel = 20;   //Xp needed to level up, the higher the level, the harder it gets.

    [Header("Player Damage")]
    public int PlayerDamage = 2;
    public float currentPlayerDamage;

    [Header("Player Magic Damage")]
    public int PlayerMagicDamage = 2;
    public float currentPlayerMagicDamage;

    [Range(0.5f, 1.5f)]
    private float fireRate = 1;

    private float timer;

    [SerializeField]
    private Transform firePoint;

    [SerializeField]
    private HealthBar _healthBar;


    private void Start()
    {
        SetCurrentPlayerHealth();
        //SetCurrentXP();
        SetXPForNextLevel();
        SetCurrentPlayerDamage();
        SetCurrentPlayerMagicDamage();

        

    }

    void SetCurrentPlayerHealth()
    {
        currentPlayerHealth = (maxPlayerHealth * level);
        Debug.Log("currentHealth = " + currentPlayerHealth);
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

    public void SetCurrentPlayerDamage()
    {
        currentPlayerDamage = (PlayerDamage * level);
        Debug.Log("currentPlayerDamage = " + currentPlayerDamage);

        //GameEvents.OnPlayerAttack?.Invoke((int)currentPlayerDamage);
    }

    public void SetCurrentPlayerMagicDamage()
    {
        currentPlayerMagicDamage = (PlayerMagicDamage * level);
        Debug.Log("currentPlayerMagicDamage =" + currentPlayerMagicDamage);
    }

    // Update is called once per frame
    void Update()
    {

        _healthBar.UpdateHealthBar(maxPlayerHealth, currentPlayerHealth);

        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            if (Input.GetButton("Fire1"))
            {
                timer = 0f;
                FireMagic();

                Instantiate(Magic, firePoint.transform);
                Rigidbody rb = Magic.GetComponent<Rigidbody>();
                rb.velocity = firePoint.forward * 1;
            }
        }
    }

    private void FireMagic()
    {
        //Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.red, 2f);

        Ray ray = new Ray(firePoint.position, firePoint.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 100))
        {
            var currentMonsterHealth = hitInfo.collider.GetComponent<MonsterStats>();

            if (currentMonsterHealth != null)
                currentMonsterHealth.TakeDamage((int)currentPlayerMagicDamage);


            //gameObject.GetComponent<MonsterStats>().TakeDamage(currentPlayerMagicDamage);
            //Destroy(hitInfo.collider.gameObject);



            //if (gameObject.CompareTag("Monsters"))
            //{
            //    gameObject.GetComponent<MonsterStats>().TakeDamage(currentPlayerMagicDamage);
            //}
        }
    }

    public void TakeDamage(int MonsterDamage)
    {
        this.currentPlayerHealth -= MonsterDamage;
        InvokeRepeating("TakeDamage", 1, 100);

        Debug.Log("MonsterDamage = " + MonsterDamage);

        if (currentPlayerHealth <= 0)
            Destroy(this.gameObject);
    }






}


//Player
//HP
//Add XP and HP would go up when XP gets to a certain point
//