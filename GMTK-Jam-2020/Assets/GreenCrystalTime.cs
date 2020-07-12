using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCrystalTime : MonoBehaviour
{
    public GameObject greenCrystal;
    public Timer TimerScript;

    void OnTriggerEnter2D(Collider2D col)
    {
        TimerScript.AddTen();
        greenCrystal.SetActive(false);
    }


}
