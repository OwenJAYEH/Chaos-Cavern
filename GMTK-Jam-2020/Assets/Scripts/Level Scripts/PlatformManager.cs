using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    // Array setup for platforms
    GameObject[] platforms;
    GameObject currentPlatform;
    GameObject currentPurpPlatform;
    GameObject currentP1Platform;
    GameObject currentP2Platform;
    int index;
    int purpIndex;
    int P1Index;
    int P2Index;
    int greenChance;
    int randomPlatP1;
    int randomPlatP2;

    public bool DropEvent = false;

    // GameObject for the collision of currently selected platform
    public GameObject currentPlatCol;
    public GameObject currentPlatLight;
    public GameObject purpleCrystal;
    public GameObject greenCrystal;

    public GameObject PlayerOne;
    public GameObject PlayerTwo;


    public GameObject tenSec;



    public void dropBoolToggleOn()
    {
        DropEvent = true;
    }

    public void dropBoolToggleOff()
    {
        DropEvent = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        platforms = GameObject.FindGameObjectsWithTag("platform"); // Creates an array of all objects with the tag platform
        index = Random.Range(0, platforms.Length); // randomly selects one platform
        currentPlatform = platforms[index]; // registers random platform as the one the player must get to
        print(currentPlatform.name); // Prints name for debug purposes
        purpIndex = index = Random.Range(0, platforms.Length);
        currentPurpPlatform = platforms[purpIndex];

        currentPlatCol.transform.position = new Vector2 (currentPlatform.transform.position.x, currentPlatform.transform.position.y + .45f); // Moves collission to platform and adds height
        currentPlatLight.transform.position = currentPlatCol.transform.position;
        purpleCrystal.transform.position = new Vector2(currentPlatform.transform.position.x + .5f, currentPlatform.transform.position.y + .6f);
        greenCrystal.transform.position = new Vector2(currentPurpPlatform.transform.position.x, currentPurpPlatform.transform.position.y+1.2f); // to make it only reachable from the top
    }

    public void RandomPlace()
    {
        P1Index = Random.Range(0, platforms.Length);
        P2Index = Random.Range(0, platforms.Length);
        currentP1Platform = platforms[P1Index];
        currentP2Platform = platforms[P2Index];

        PlayerOne.transform.position = new Vector2(currentP1Platform.transform.position.x, currentP1Platform.transform.position.y + .5f);
        PlayerTwo.transform.position = new Vector2(currentP2Platform.transform.position.x, currentP2Platform.transform.position.y + .5f);


    }

    // Function repeats the process above
    public void NewPlatform()
    {

        tenSec.SetActive(false);


        greenChance = Random.Range(0, 5);
      if (greenChance == 0)
        {
            greenCrystal.SetActive(true);
        }
      
    
      index = Random.Range(0, platforms.Length);
      currentPlatform = platforms[index];
      purpIndex = index = Random.Range(0, platforms.Length);
      currentPurpPlatform = platforms[purpIndex];
      currentPlatCol.transform.position = new Vector2(currentPlatform.transform.position.x, currentPlatform.transform.position.y + .45f);
      currentPlatLight.transform.position = currentPlatCol.transform.position;
      purpleCrystal.transform.position = new Vector2(currentPlatform.transform.position.x + .5f, currentPlatform.transform.position.y + .6f);
      greenCrystal.transform.position = new Vector2(currentPurpPlatform.transform.position.x, currentPurpPlatform.transform.position.y+1.2f); // to make it only reachable from the top
    }


    void Update()
    {
        switch (DropEvent)
        {
            case false:
                DropEventToggleOff();
                break;
            case true:
                DropEventToggleOn();
                break;
        }
    }

    void DropEventToggleOn()
    {
        platforms = GameObject.FindGameObjectsWithTag("platform"); // Creates an array of all objects with the tag platform
        for (int i = 0; i < platforms.Length; i++)
        {
            platforms[i].GetComponent<PlatformDrop>().enabled = true;
        }
    }

    void DropEventToggleOff()
    {
        platforms = GameObject.FindGameObjectsWithTag("platform"); // Creates an array of all objects with the tag platform
        for (int i = 0; i < platforms.Length; i++)
        {
            platforms[i].GetComponent<PlatformDrop>().StartOver();
            platforms[i].GetComponent<Renderer>().enabled = true;
            platforms[i].GetComponent<BoxCollider2D>().enabled = true;
            platforms[i].GetComponent<PlatformDrop>().enabled = false;
        }
    }

}
