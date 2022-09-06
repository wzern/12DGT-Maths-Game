using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class RandMathGen : MonoBehaviour
{
    public static float playerScore;
    public static float highScore;
    // First Random
    Random randNumOne = new Random();
    // Second Random
    Random randNumTwo = new Random();
    // Divison Equation Random
    Random divisionEquation = new Random();
    // Determines which function is used
    public static int calcFunction;
    // First Number of Equation
    public static int calcNumOne;
    // Second Number of Equation
    public static int calcNumTwo;
    // Math Answer Integer to compare against input
    public static int mathAnswer;
    // Determines which division question is used
    public static int divisionEquationSwitch;
    // Main Equation for GUI
    public static string mathEquation;
    // Input string from player
    public static string answerInput;
    // If true, code will wait until false to generate new question
    public static bool wait;
    // Displays text on GUI
    Text txt;                                 

    public static int calcNumOneMin = 16;
    public static int calcNumOneMax = 26;
    public static int calcNumTwoMin = 0;
    public static int calcNumTwoMax = 16;

    void Start()
    {
        mathEquation = null;
        wait = false;
        txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Calls RandMathGenVoid if wait is false
        if (!wait)
        {
            RandMathGenVoid();
            wait = true;
            txt.text = mathEquation;
            Debug.Log(mathAnswer);
        }

        // Get text input, if matches answer then destroy asteroid
        if (PlayerInput.answer == mathAnswer.ToString() && wait)
        {
            // Destroy asteroid if answer is correct
            Destroy(GameObject.FindWithTag("asteroid"));
            // This calls asteroidSpawnScript to spawn a new asteorid
            asteroidSpawnScript.spawnNew = true; 
            playerScore = playerScore + 1;
            wait = false;
        }

        // on asteroid collision generate new question
        if (AsteroidCollision.collided)
        {
            AsteroidCollision.collided = false;
            wait = false;
        }
    }

    // Generate Question and Calculate Answer
    public void RandMathGenVoid()
    {
        //Generate Function ( + , - , * or / )
        Random randFunction = new Random();
        // -- will either be 1 (+) , 2 (-) , 3 (*) , 4 (/)
        calcFunction = randFunction.Next(1, 5); 
        switch (calcFunction)
        {
            // Addition
            case 1: 
                calcNumOne = randNumOne.Next(calcNumOneMin, calcNumOneMax);
                calcNumTwo = randNumTwo.Next(calcNumTwoMin, calcNumTwoMax);
                mathEquation = calcNumOne.ToString() + " + " + calcNumTwo.ToString();
                mathAnswer = calcNumOne + calcNumTwo;
                break;
            // Subtraction: Larger number - Smaller Number (To avoid negative numbers)
            case 2: 
                calcNumOne = randNumOne.Next(calcNumOneMin, calcNumOneMax);
                calcNumTwo = randNumTwo.Next(calcNumTwoMin, calcNumTwoMax);
                mathEquation = calcNumOne.ToString() + " - " + calcNumTwo.ToString();
                mathAnswer = calcNumOne - calcNumTwo;
                break;
            // Multiplication: Generates smaller numbers to multiply together
            case 3:
                // -- will be between 1 and 3
                calcNumOne = randNumOne.Next(1, 4);
                // -- will be between 2 and 6
                calcNumTwo = randNumTwo.Next(2, 7);    
                mathEquation = calcNumOne.ToString() + " X " + calcNumTwo.ToString();
                mathAnswer = calcNumOne * calcNumTwo;
                break;

            // Division: Chooses from predifined sets of numbers to avoid decimals
            case 4: 
                divisionEquationSwitch = divisionEquation.Next(1, 11);
                switch (divisionEquationSwitch)
                {
                    // 9 ÷ 3
                    case 1: 
                        calcNumOne = 9;
                        calcNumTwo = 3;
                        break;
                    // 8 ÷ 2
                    case 2: 
                        calcNumOne = 8;
                        calcNumTwo = 2;
                        break;
                    // 6 ÷ 1
                    case 3: 
                        calcNumOne = 6;
                        calcNumTwo = 1;
                        break;
                    // 100 ÷ 10
                    case 4: 
                        calcNumOne = 100;
                        calcNumTwo = 10;
                        break;
                    // 50 ÷ 2
                    case 5: 
                        calcNumOne = 50;
                        calcNumTwo = 2;
                        break;
                    // 60 ÷ 12
                    case 6: 
                        calcNumOne = 60;
                        calcNumTwo = 12;
                        break;
                    // 12 ÷ 4
                    case 7: 
                        calcNumOne = 12;
                        calcNumTwo = 4;
                        break;
                    // 18 ÷ 9
                    case 8: 
                        calcNumOne = 18;
                        calcNumTwo = 9;
                        break;
                    // 12 ÷ 3
                    case 9: 
                        calcNumOne = 12;
                        calcNumTwo = 3;
                        break;
                    // 81 ÷ 9
                    case 10: 
                        calcNumOne = 81;
                        calcNumTwo = 9;
                        break;
                    // Called when values don't match any cases above (i.e. this would be an error)
                    default: 
                        calcNumOne = 1;
                        calcNumTwo = 1;
                        break;
                }

                mathEquation = calcNumOne.ToString() + " / " + calcNumTwo.ToString();
                mathAnswer = calcNumOne / calcNumTwo;
                break;
            // Called when values don't match any cases above (i.e. this would be an error)
            default:
                mathEquation = null;
                mathAnswer = 0;
                break;
        }
    }
}