using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easyMode : MonoBehaviour
{
    // variables = bool easy
    public static bool easy = false;

    // if mouse1 down
    void OnMouseDown()
    {        
        // sets bool easy to true and hard / medium to false
        Debug.Log("Easy Mode Activated");
        easy = true;
        hardMode.hard = false;
        mediumMode.medium = false;
    }
}
