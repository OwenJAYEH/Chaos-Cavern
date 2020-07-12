using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class currentPlatCol : MonoBehaviour
{
    public PlatformManager PlatformManagerScript;
    public GameManagerScript GameManager;
    public EventRandomizer RandomizerScript;
    public Timer TimerScript;

    public Animator animator1;
    public Animator animator2;

    bool playerOneGoal = false;
    bool playerTwoGoal = false;

    // Function makes booleans true when Player One or Player Two is colliding with the goal
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerOne")
        {
            playerOneGoal = true;
            animator1.SetBool("OnPurp1", true);
        }

        if (col.gameObject.tag == "PlayerTwo")
        {
            playerTwoGoal = true;
            animator2.SetBool("OnPurp2", true);
        }
    }


    // Function makes booleans false when Player One or Player Two stops colliding with goal
    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerOne")
        {
            playerOneGoal = false;
            animator1.SetBool("OnPurp1", false);
        }

        if (col.gameObject.tag == "PlayerTwo")
        {
            playerTwoGoal = false;
            animator2.SetBool("OnPurp2", false);
        }
    }

    // If both the players are colliding with the goal, a new platform is selected and the player must reach that goal
    void Update()
    {
        if (playerTwoGoal == true && playerOneGoal == true)
        {
            PlatformManagerScript.NewPlatform();
            GameManager.AddPoint();
            TimerScript.AddFive();
            RandomizerScript.Randomizer();
            playerTwoGoal = false;
            playerOneGoal = false;
        }
    }
}
