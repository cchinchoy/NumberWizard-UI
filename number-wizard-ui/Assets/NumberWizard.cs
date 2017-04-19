using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;

	int nextGuess = 10;
	public Text text;

	void Start () {
		StartGame();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
		guess = Random.Range (min, max);
		text.text = guess.ToString();
	}

	public void higherGuess(){
		min = guess;
		NextGuess();
	}

	public void lowerGuess(){
		max = guess;
		NextGuess();
	}
	void NextGuess () {
		nextGuess = nextGuess - 1; 
		guess = Random.Range (min, max);
		text.text = guess.ToString();
		print (guess);
		print (nextGuess);
		if (nextGuess <= 0) {
			Application.LoadLevel ("Win");
		} 
	}
}
