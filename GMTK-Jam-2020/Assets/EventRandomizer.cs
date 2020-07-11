using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRandomizer : MonoBehaviour
{

    public CameraFlip CameraFlipScript;
    public PlatformManager PlatformManagerScript;
    public SlowMotion SlowMotionP1Script;
    public SlowMotion SlowMotionP2Script;
    public PlayerOneMovement PlayerOneScript;
    public PlayerTwoMovement PlayerTwoScript;

    public GameObject PlayerOne;
    public GameObject PlayerTwo;

    public int randomizedInt;

    public void Randomizer()
    {
        randomizedInt = Random.Range(0, 5);

        PlatformManagerScript.dropBoolToggleOff();
        CameraFlipScript.flipCameraToggleOff();
        SlowMotionP1Script.slowMoToggleOff();
        SlowMotionP2Script.slowMoToggleOff();
        PlayerOneScript.tripleSpeedToggleOff();
        PlayerTwoScript.tripleSpeedToggleOff();
        PlayerOne.GetComponent<PlayerOneMovement>().enabled = true;
        PlayerTwo.GetComponent<PlayerTwoMovement>().enabled = true;
        PlayerOne.GetComponent< PlayerOneMirrorMovement>().enabled = false;
        PlayerTwo.GetComponent<PlayerTwoMirrorMovement>().enabled = false;


        switch (randomizedInt)
        {
            case 0:
                print("Camera Flip Event Triggered");
                CameraFlipScript.flipCameraToggleOn();
                break;
            case 1:
                print("Drop Event Triggered");
                PlatformManagerScript.dropBoolToggleOn();
                break;
            case 2:
                print("Slow Motion Event Triggered");
                SlowMotionP1Script.slowMoToggleOn();
                SlowMotionP2Script.slowMoToggleOn();
                break;
            case 3:
                print("Triple Speed Event Triggered");
                PlayerOneScript.tripleSpeedToggleOn();
                PlayerTwoScript.tripleSpeedToggleOn();
                break;
            case 4:
                print("Mirrored Controls Triggered");
                PlayerOne.GetComponent<PlayerOneMovement>().enabled = false;
                PlayerTwo.GetComponent<PlayerTwoMovement>().enabled = false;
                PlayerOne.GetComponent<PlayerOneMirrorMovement>().enabled = true;
                PlayerTwo.GetComponent<PlayerTwoMirrorMovement>().enabled = true;
                break;



        }
    }
}
