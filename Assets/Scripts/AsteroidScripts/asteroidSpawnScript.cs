using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawnScript : MonoBehaviour
{
    // Spawn rate, public timer and gameobject implemented
    public GameObject asteroid;
    public static bool spawnNew;
    public float timeToWait = 3f;
    float randX;
    float timer;
    Vector2 WhereToSpawn;

    void Start()
    {
        spawnNew = true;
    }

    void Update()
    {
        // on asteroid collision spawn asteroid at random x position
        if (spawnNew)
        {
            // stops spawning until current asteroid has collided
            spawnNew = false;
            // gets random float inbetween -5.74 and 5.52 and stores in randX
            randX = Random.Range(-5.74f, 5.52f);
            // gets asteroid spawn location within a vector2 and stored in WhereToSpawn variable, uses randX for a random position along the x axis
            WhereToSpawn = new Vector2(randX, transform.position.y);
            // Instantiate asteroid spawn depening on WhereToSpawn location
            Instantiate(asteroid, WhereToSpawn, Quaternion.identity);
        }
    }
}
