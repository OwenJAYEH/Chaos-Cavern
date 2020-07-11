using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRandomizer : MonoBehaviour
{

    public CameraFlip CameraFlipScript;
    public PlatformManager PlatformManagerScript;
    public SlowMotion SlowMotionP1Script;
    public SlowMotion SlowMotionP2Script;

    public int randomizedInt;

    public void Randomizer()
    {
        randomizedInt = Random.Range(0, 3);

        PlatformManagerScript.dropBoolToggleOff();
        CameraFlipScript.flipCameraToggleOff();
        SlowMotionP1Script.slowMoToggleOff();
        SlowMotionP2Script.slowMoToggleOff();


        switch (randomizedInt)
        {
            case 0:
                CameraFlipScript.flipCameraToggleOn();
                print("Camera Flip Event Triggered");
                break;
            case 1:
                PlatformManagerScript.dropBoolToggleOn();
                print("Drop Event Triggered");
                break;
            case 2:
                SlowMotionP1Script.slowMoToggleOn();
                SlowMotionP2Script.slowMoToggleOn();
                print("Slow Motion Event Triggered");
                break;
                

        }
    }
}
