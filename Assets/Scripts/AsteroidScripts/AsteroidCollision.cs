using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    // Creating and setting scoreCount / lives left
    public static float scoreCount;
    public static bool collided;
    int count = 0;

    private void Start()
    {
        // Applies score int to score float
        scoreCount = 7.674f;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Implements score loss on collision and shows amount of collisions in unity log
        if (col.gameObject.tag == "asteroid")
        {
            // adds one to current score, subtracts 1/3 off of current population left (2.558f)
            count = count + 1;
            Debug.Log("hit " + count);
            Destroy(col.gameObject);
            scoreCount = scoreCount - 2.558f;
            // this calls RandMathGen script to generate new question and set collided back to false
            collided = true;
            // This calls asteroidSpawnScript to spawn a new asteorid
            asteroidSpawnScript.spawnNew = true; 
        }
    }
}