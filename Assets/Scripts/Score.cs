/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * Score OverView
 	* Component of Score UI
 	* Updates score on top left of screen as time goes on
 	* Increases speed of obstacles periodically by accessing GameManager.cs
 	* Saves current score and updates high score when necessary

 * Functions/Variables
 	* score
 		* int
 		* increments when AddScore() is called (every .2 seconds)
	* compare
		* int
		* baseline for speed incrementing
		* increases by 50 everytime score surpasses it
	* gameManager
		* GameObject
		* GameManager holder
	* player
		* GameObject
		* player holder
	* levelUpSound
		* AudioClip
		* sound played when compare increments
	* source
		* AudioSource
		* accesses audio component
	* AddScore()
		* add a point to score every time it is called by InvokeRepeating
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//variables
	public int score;
	public int compare = 50;

	public GameObject gameManager;
	public GameObject player;

	public AudioClip levelUpSound;
	private AudioSource source;

	// Use this for initialization
	void Start()
	{
		source = GetComponent<AudioSource>();
		InvokeRepeating("AddScore", 0, .2f); //invokes method name at runTime, then repeatedly every .2 seconds
	}

	// Update is called once per frame
	void Update() 
	{
		this.gameObject.GetComponent<Text>().text = "SCORE " + score.ToString("000000"); //updates text UI
		if (score > compare)
		{
			source.PlayOneShot(levelUpSound, 1f);
			gameManager.GetComponent<GameManager>().speed += .5f; //accesses speed from GameManager.cs and increments by .5
			compare += 50; //increments baseline
		}
		if (player == null) //when player dies
		{
			PlayerPrefs.SetInt("TempScore", score); //saves current score
			if (PlayerPrefs.GetInt("HighScore") < score) //replaces high score if current score is higher
			{
				PlayerPrefs.SetInt("HighScore", score);
			}
		}
	}

	public void AddScore()
	{
		score += 1;
	}
			

}
