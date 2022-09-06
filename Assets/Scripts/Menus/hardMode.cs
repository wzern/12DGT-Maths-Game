using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardMode : MonoBehaviour
{
    public static bool hard = false;

    void OnMouseDown()
    {
        // set bool hard mode = true, easy / medium mode false
        Debug.Log("Hard Mode Activated");
        hard = true;
        easyMode.easy = false;
        mediumMode.medium = false;
    }
}
