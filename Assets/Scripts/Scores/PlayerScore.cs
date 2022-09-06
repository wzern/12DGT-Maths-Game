using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
        // sets variabls - playerscore and txt
        Text txt;
        float playerscore;

        private void Start()
        {
            // accesses textUI game object as txt
            txt = gameObject.GetComponent<Text>();
        }

        private void Update()
        {
            // displays players current score in game
            txt.text = "Score: " + RandMathGen.playerScore;
        }

}
