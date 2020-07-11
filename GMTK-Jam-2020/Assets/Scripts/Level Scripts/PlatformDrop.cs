using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{
    float countDownTimer = 2f;

    bool playerEnter = false;

    public void StartOver()
    {
        countDownTimer = 0f;
    }
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerOne")
        {
            playerEnter = true;
        }
        if (col.gameObject.tag == "PlayerTwo")
        {
            playerEnter = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        countDownTimer = 0f;
    }

    void Update()
    {
        if (countDownTimer < -2f)
        {
            playerEnter = false;
            countDownTimer = 2f;
        }

        if (countDownTimer < 0f)
        {
            GetComponent<Renderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (playerEnter == true)
        {
            countDownTimer -= 1 * Time.deltaTime;
        }

        if (playerEnter == false)
        {
            GetComponent<Renderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }

        print(countDownTimer);
    }
}