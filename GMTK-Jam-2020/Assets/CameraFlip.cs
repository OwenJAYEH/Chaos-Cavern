using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlip : MonoBehaviour
{

    public bool flipCamera = false;

    public void flipCameraToggleOn()
    {
        flipCamera = true;
    }
    public void flipCameraToggleOff()
    {
        flipCamera = false;
    }

    void Update()
    {

        switch (flipCamera)
        {
            case false:
                transform.eulerAngles = new Vector3(0, 0, 0f);
                break;
            case true:
                transform.eulerAngles = new Vector3(0, 0, 180f);
                break;
        }
    }
}
