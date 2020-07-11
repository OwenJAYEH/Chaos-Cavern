using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    public void AddPoint()
    {
        points += 1;
        print(points);
    }

    void Update()
    {
        switch (points)
        {
            case 0:
                break;
            case 1:
                print("Random Event Engaged");
                break;
        }
    }
}
