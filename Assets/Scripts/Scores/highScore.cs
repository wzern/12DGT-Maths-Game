using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour
{
    // sets variables - txt
    Text txt;

    private void Start()
    {
        // accesses textUI game object as txt
        txt = gameObject.GetComponent<Text>();
    }

    private void Update()
    {
        // displays player high score in fail menu
        txt.text = "High Score: " + RandMathGen.highScore;
    }
}
