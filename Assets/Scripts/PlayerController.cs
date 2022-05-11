using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    
    [Header("Player")]
    [Tooltip("Move speed of the character in m/s")]
    public float MoveSpeed = 2.0f;
    public float currentMoveSpeed;

    [Space(10)]
    [Tooltip("Sprint speed of the character in m/s")]
    public float SprintSpeed = 5.335f;
    public float currentSprintSpeed;

    [Space(10)]
    [Tooltip("How fast the character turns to face movement direction")]
    //[Range(0.0f, 100f)]
    public float TurnSpeed = 100f;
    public float currentTurnSpeed;

    [Space(10)]
    [Tooltip("The height the player can jump")]
    public float JumpHeight = 5f;
    public float currentJumpHeight;

    //private int damage;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && Mathf.Abs(this.GetComponent<Rigidbody>().velocity.y) < 0.01f)
        {
            this.GetComponent<Rigidbody>().velocity += Vector3.up * this.JumpHeight;
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            this.transform.position += this.transform.forward * Time.deltaTime * this.MoveSpeed;
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            this.transform.position -= this.transform.forward * Time.deltaTime * this.MoveSpeed;
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            this.transform.Rotate(this.transform.up, Time.deltaTime * -this.TurnSpeed);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            this.transform.Rotate(this.transform.up, Time.deltaTime * this.TurnSpeed);
        }

        //if (Input.GetMouseButtonDown(0) == true)
        //{
            
        //}
        
    }
}

//Player
//In 3rd person
//Able to move around the game level
//Get WSADcontroller
//Spacebar for jump
//Attack controls


