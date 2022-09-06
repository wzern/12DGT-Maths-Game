using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{
    // if mouse1 down on quitGame gameObject, quit application
    private void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
