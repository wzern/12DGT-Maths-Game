using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class asteroidMovement : MonoBehaviour
{
    // variables = bools easy, medium, hard, sets speed to 0, rb as rigidbody component
    bool easy;
    bool medium;
    bool hard;
    public int speed = 0;
    public Rigidbody2D rb;

    private void Start()
    {
        //Gets access for Rigidbody2D on prefab stores it as rb
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
 

    void Update()
    {
        // assigning bools as they currently are in difficulty scrips
        easy = easyMode.easy;
        medium = mediumMode.medium;
        hard = hardMode.hard;

        // changing asteroid speeds depening on difficulty
        if (easy)
        {
            speed = 1;
        }

        if (medium)
        {
            speed = 3;
        }

        if(hard)
        {
            speed = 5;
        }

        //Creates movement for asteroid on spawn
        transform.position += -transform.up * speed * Time.deltaTime;
    }
}


