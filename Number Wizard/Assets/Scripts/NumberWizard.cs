using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	private int max;
	private int min;
	private int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		max = 1000;
		min = 0;
		guess = (int)Random.Range(min, max);

		print ("===================================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");

		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return) ) {
			print ("I Won");
			StartGame();
		}
	}

	private void NextGuess() {
		guess = (min + max) / 2;
		print ("Higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
	}
	
}
