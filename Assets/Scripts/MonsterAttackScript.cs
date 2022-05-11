using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterAttackScript : MonoBehaviour

{
    public MonsterStats Script;

    //Animator animator;

    [Header("Speed")]
    public float MoveSpeed = 2.0f;

    [Header("Speed")]
    public float RotationSpeed = 2.0f;
    private object MonsterDamage;

    public void Start()
    {
        //animator = GetComponent<Animator>();

    }

    private void OnTriggerStay(Collider other)
    {
        //bool isWalking = animator.GetBool("isWalking");

        if (other.CompareTag("Player"))
        {
            //Makes monster move towards player//
            var step = MoveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, step);

            //Makes the monster turn towards you//

            //animator.SetBool("isWalking", true);

            Vector3 targetDirection = other.transform.position - transform.position;
            float singleStep = RotationSpeed * Time.deltaTime;

            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //animator.SetBool("isWalking", false);

        }


    }

    
}
        
    