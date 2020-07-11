using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class currentPlatCol : MonoBehaviour
{
    public PlatformManager PlatformManagerScript;

    bool playerOneGoal = false;
    bool playerTwoGoal = false;

    // Function makes booleans true when Player One or Player Two is colliding with the goal
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerOne")
        {
            playerOneGoal = true;
        }

        if (col.gameObject.tag == "PlayerTwo")
        {
            playerTwoGoal = true;
        }
    }


    // Function makes booleans false when Player One or Player Two stops colliding with goal
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerOne")
        {
            playerOneGoal = false;
        }

        if (col.gameObject.tag == "PlayerTwo")
        {
            playerTwoGoal = false;
        }
    }

    // If both the players are colliding with the goal, a new platform is selected and the player must reach that goal
    void Update()
    {
        if (playerTwoGoal == true && playerOneGoal == true)
        {
            PlatformManagerScript.NewPlatform();
        }
    }
}
