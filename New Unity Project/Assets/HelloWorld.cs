using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int guess;
    int max = 1000;
    int min = 1;

    // Start is called before the first frame update
    void Start()
    {        
        StartGame();
    }

    void ReStart()
    {
        max = 1000;
        min = 1;
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, don't tell me yet");
        Debug.Log($"Highest number you can pick is <b>{max}</b>");
        Debug.Log($"Lowest number is <b>{min}</b>");
        NextGuess(min, max);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            ReStart();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow)) {         
            min = guess;
            NextGuess(min, max);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {         
            max = guess;
            NextGuess(min, max);
        }
        else if (Input.GetKeyUp(KeyCode.Return)) {         
            Debug.Log($"Your number is <b><size=20><color=green>{guess}</color></size></b>");
            ReStart();
        }       
    }

    void NextGuess(int min, int max)
    {
        guess = (min + max) / 2;

        if (max-min <= 2) {
            Debug.Log($"Your number is <b><color=green>{guess}</color></b>");
            ReStart();
            return;
        }
        
        Debug.Log($"Is your number higer or lower than {guess}?");
        Debug.Log($"Press 'Up arrow' key if higher, Press 'Down arrow' key if lower, press Enter if it is equal!");
    }
}
