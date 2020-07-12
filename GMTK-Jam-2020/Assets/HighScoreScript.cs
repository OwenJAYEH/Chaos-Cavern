using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    public int highScore;
    string highScoreKey = "HighScore";
    public TMPro.TextMeshProUGUI HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        HighScoreText.text = ("Highscore: " + highScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
