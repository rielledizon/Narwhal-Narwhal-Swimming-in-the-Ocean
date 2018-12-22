/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * KillTrigger OverView
 	* Component of each obstacle within the obstacle group Prefabs
 	* Kills player and loads game over screen when player hits the obstacle

 * Functions/Variables
	* OnTriggerEnter()
		* returns void
		* paramater checks if the object that enters the obstacle is the player
		* destroys player instantly and switches scenes to the "GameOver" scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
			SceneManager.LoadScene("GameOver");
		}
	}

}
