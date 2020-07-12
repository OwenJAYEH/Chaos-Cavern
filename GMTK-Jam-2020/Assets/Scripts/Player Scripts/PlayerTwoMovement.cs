using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    // Initialized public variables for use inside of the inspector
    public PlayerTwoCharacterController2D controller;
    public Animator animator;

    // Initialized variables
    // Variable for player run speed
    public float runSpeed = 100f;
    // Variable used for player movement left and right
    float horizontalMove = 0f;

    // Booleans for Jumping
    bool jump = false;

    // Boolean for Triple Speed Event
    public bool tripleSpeed = false;


    public void tripleSpeedToggleOn()
    {
        tripleSpeed = true;
    }
    public void tripleSpeedToggleOff()
    {
        tripleSpeed = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Uses players input of A and D keys to move character in FixedUpdate
        horizontalMove = Input.GetAxisRaw("p2Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        // Uses players input of SpaceBar to make the character Jump
        if (Input.GetButtonDown("P2Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        // EVENTS TRIGGERED WHEN PLAYER SCORES A POINT

        // Triple Speed Event
        switch (tripleSpeed)
        {
            case false:
                runSpeed = 100f;
                break;
            case true:
                runSpeed = 300f;
                break;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        // Disables jump so player cannot jump twice
        jump = false;
    }
}
