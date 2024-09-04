using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    // Create a method that accepts an integer, operates it and prints out the result.
    // Create a method that accepts an integer, with an if statement about this integer.
    // Print something inside the if body, and inside the else body.
    // Create a method that accepts an integer, with a switch statement with 3 cases about this integer
    // Print something in the cases.

    void Start()
    {
        AcceptInterger(10);
        ConditionsInterger(6);
        ThreeSwitchCases(1);
    }

    void AcceptInterger(int accepted)
    {
        Debug.Log($"Your morale is now {accepted}");
    }

    void ConditionsInterger(int onlyIf)
    {
        Debug.Log($"You muster up the courage and jump {onlyIf} feet!");

        if (onlyIf >= 3)
        {
            Debug.Log("You made the jump across the cliff and survived!");
        }
        else
        {
            Debug.Log("Oh no, you fell 25 feet down to your death, landed on your face and died.");
        }
    }
    void ThreeSwitchCases(int SwitchCases)
    {
        switch (SwitchCases)
        {

            case 1:
                Debug.Log("You chose the first path and found a very peculair item. It might be helpful to get you out of here");
                break;
            case 2:
                Debug.Log("You chose the second path and found a half empty water bottle. You won't die of thirst, for now");
                break;

            case 3:
                Debug.Log("You chose the third path and tripped on a rock, leading you to fall on your face and break a tooh in the process.");
                Debug.Log("Why does this scenerio feel familiar?");
                break;

            default:
                Debug.Log("There is no fourth path. That's an invisible wall that leads to the Pale. Are you crazy?");

                break;
        }
    }
}