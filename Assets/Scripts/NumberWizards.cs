using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NumberWizards : MonoBehaviour {
	// Use this for initialization
	public Text guessText;
	
	int max = 10000;
	int min = 1;
	int guess;
	
	
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = max + 1;
		NextGuess();
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess();
	}
	
	void NextGuess () {		
		guess = Random.Range(min, max);
		guessText.text = guess.ToString();
	}
}
