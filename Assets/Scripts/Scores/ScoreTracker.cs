using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{
    // Get RGBA colours for death text (red)
    float r = 255f, g = 0f, b = 0f, a = 1f;
    // Getting access to text ui and creating float int
    static float score; 
    Text txt;

    private void Start()
    {
        // accessing text ui 
        txt = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        // pulling score count from AsteroidCollision srcipt
        score = AsteroidCollision.scoreCount;
        // Displays current score in game ui
        txt.text = "Population : " + score + " B";

        if (score <= 0)
        {
            // Implemented loss feature and changing text ui to red, loa fail menu scene
            txt.text = "EARTH STATUS: DEAD";
            txt.color = new Color(r, g, b, a);
            SceneManager.LoadScene("FailMenu");

            // updates player high-score if current score is greater 
            if (RandMathGen.playerScore > RandMathGen.highScore)
            {
                RandMathGen.highScore = RandMathGen.playerScore;
            }
        }

    }
}

