using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // variables - playerscore
    float playerscore;

    // on mouse1 down and if either of easy, medium or hard mode is selected, run main scene 
    void OnMouseDown()
    {
        if (easyMode.easy || mediumMode.medium || hardMode.hard)
        {
            SceneManager.LoadScene("MainScene");
            // reset player score float to 0
            RandMathGen.playerScore = 0;
        }
    }
}

