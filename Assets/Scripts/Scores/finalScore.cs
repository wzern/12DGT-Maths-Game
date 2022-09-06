using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    // sets variabls - finalscore, txt
    Text txt;
    float finalscore;

    void Start()
    {
        // accesses textUI game object as txt
        txt = gameObject.GetComponent<Text>();
    }

    private void Update()
    {
        // accesses current payer score and displays it in fail menu as final score
        finalscore = RandMathGen.playerScore;
        txt.text = "Score: " + finalscore;
    }

}
