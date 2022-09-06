using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mediumMode : MonoBehaviour
{
    // variables - medium bool = true
    public static bool medium = false;

    // if mouse1 down
    void OnMouseDown()
    {
        // set bool medium mode = true, easy / hard mode false
        Debug.Log("Medium Mode Activated");
        medium = true;
        hardMode.hard = false;
        easyMode.easy = false;
    }
}
