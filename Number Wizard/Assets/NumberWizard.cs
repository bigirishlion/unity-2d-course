using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pressed up!");
            min = guess;
            Debug.Log(min);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You pressed down!");
            max = guess;
            Debug.Log(max);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You pressed enter!");
        }
	}
}
