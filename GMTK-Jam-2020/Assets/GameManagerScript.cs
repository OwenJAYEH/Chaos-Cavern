using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public int points;
    public int highScore = 0;
    public TMPro.TextMeshPro highScoreText;


    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    public void AddPoint()
    {
        points += 1;
        print(points);
        highScoreText.text = ("Score: ") + points.ToString();
        
        if (highScore < points)
        {
            highScore = points;
        }

        print("Highscore: " + highScore);
    }

}
