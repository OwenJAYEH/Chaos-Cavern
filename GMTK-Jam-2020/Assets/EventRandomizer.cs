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
    public PlayerOneBouncy PlayerOneBouncyScript;
    public PlayerTwoBouncy PlayerTwoBouncyScript;
    public PlayerOneCharacterController2D PlayerOneCC;
    public PlayerTwoCharacterController2D PlayerTwoCC;
    
    public GameObject PlayerOne;
    public GameObject PlayerTwo;

    public GameObject bg_normal;
    public GameObject bg_bouncy;
    public GameObject bg_mirror;
    public GameObject bg_doubleJump;
    public GameObject bg_speed;
    public GameObject bg_slow;
    public GameObject bg_fall;
    public GameObject bg_ice;

    public GameObject canvas_slow;
    public GameObject canvas_icy;
    public GameObject canvas_bouncy;
    public GameObject canvas_vanish;
    public GameObject canvas_jumpy;
    public GameObject canvas_fast;
    public GameObject canvas_mirror;
    public GameObject canvas_flip;
    public GameObject canvas_random;


    public int randomizedInt;

    public void Randomizer()
    {
        randomizedInt = Random.Range(0, 8);

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
        PlayerOneBouncyScript.bouncyToggleOff();
        PlayerTwoBouncyScript.bouncyToggleOff();
        PlayerOneCC.doubleJumpToggleOff();
        PlayerTwoCC.doubleJumpToggleOff();

        bg_normal.SetActive(false);
        bg_bouncy.SetActive(false);
        bg_mirror.SetActive(false);
        bg_doubleJump.SetActive(false);
        bg_speed.SetActive(false);
        bg_slow.SetActive(false);
        bg_fall.SetActive(false);
        bg_ice.SetActive(false);

        canvas_slow.SetActive(false);
        canvas_icy.SetActive(false);
        canvas_bouncy.SetActive(false);
        canvas_vanish.SetActive(false);
        canvas_jumpy.SetActive(false);
        canvas_fast.SetActive(false);
        canvas_mirror.SetActive(false);
        canvas_flip.SetActive(false);
        canvas_random.SetActive(false);

        switch (randomizedInt)
        {
            case 0:
                print("Camera Flip Event Triggered");
                bg_normal.SetActive(true);
                canvas_flip.SetActive(true);
                CameraFlipScript.flipCameraToggleOn();
                break;
            case 1:
                print("Drop Event Triggered");
                bg_fall.SetActive(true);
                canvas_vanish.SetActive(true);
                PlatformManagerScript.dropBoolToggleOn();
                break;
            case 2:
                print("Slow Motion Event Triggered");
                bg_slow.SetActive(true);
                canvas_slow.SetActive(true);
                SlowMotionP1Script.slowMoToggleOn();
                SlowMotionP2Script.slowMoToggleOn();
                break;
            case 3:
                print("Triple Speed Event Triggered");
                bg_speed.SetActive(true);
                canvas_fast.SetActive(true);
                PlayerOneScript.tripleSpeedToggleOn();
                PlayerTwoScript.tripleSpeedToggleOn();
                break;
            case 4:
                print("Mirrored Controls Triggered");
                bg_mirror.SetActive(true);
                canvas_mirror.SetActive(true);
                PlayerOne.GetComponent<PlayerOneMovement>().enabled = false;
                PlayerTwo.GetComponent<PlayerTwoMovement>().enabled = false;
                PlayerOne.GetComponent<PlayerOneMirrorMovement>().enabled = true;
                PlayerTwo.GetComponent<PlayerTwoMirrorMovement>().enabled = true;
                break;
            case 5:
                bg_bouncy.SetActive(true);
                canvas_bouncy.SetActive(true);
                print("Bouncy Mode Triggered");
                PlayerOneBouncyScript.bouncyToggleOn();
                PlayerTwoBouncyScript.bouncyToggleOn();
                break;
            case 6:
                print("Double Jump Triggered");
                canvas_jumpy.SetActive(true);
                bg_doubleJump.SetActive(true);
                PlayerOneCC.doubleJumpToggleOn();
                PlayerTwoCC.doubleJumpToggleOn();
                break;
            case 7:
                print("Random Event Triggered");
                bg_normal.SetActive(true);
                canvas_random.SetActive(true);
                PlatformManagerScript.RandomPlace();
                break;
        }
    }
}
