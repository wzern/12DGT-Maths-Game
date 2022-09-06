using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{   // variables - playerScore, answer, assigns InputField as clearIt
    public static float playerScore;
    public static string answer;
    public InputField clearIt;
    InputField myInputField;


    private void Start()
    {
        // assigns clearIt to current InputField
        clearIt.ActivateInputField();
    }

    public void ReadStringInput(string answerinput)
    {
        answer = answerinput;
        submittingClear();
        playerScore = playerScore + 1;
        Debug.Log(answer);
    }

    // void submittingClear, clears current int / string within the InputField
    private void submittingClear()
    {
        clearIt.text = "";
        clearIt.ActivateInputField();

    }

}