/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * HighScore OverView
 	* Component of HighScore UI and Score UI on game over screen
 	* Displays and updates HighScore and current game score on the game over screen
 	* Accesses Playerprefs to find high scores

 * Functions/Variables
 	* highScoreText
 		* GameObject
 		* display high score
	* attemptScoreText
		* GameObject
		* display current attempted game score
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	//variables
	public GameObject highScoreText;
	public GameObject attemptScoreText;

	// Use this for initialization
	void Start () {
		attemptScoreText = GameObject.FindGameObjectWithTag("attemptScore"); //tagged instead of dragging components into unity boxes
		highScoreText = GameObject.FindGameObjectWithTag("highScore");

		attemptScoreText.GetComponent<Text>().text = "SCORE " + PlayerPrefs.GetInt("TempScore");
		highScoreText.GetComponent<Text>().text = "BEST " + PlayerPrefs.GetInt("HighScore");
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
