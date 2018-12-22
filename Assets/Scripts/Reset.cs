/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * Reset OverView
 	* Component of empty GameObject ResetPlayerPrefs
 	* Resets/deletes all current scores stored in player prefs

 * Functions/Variables
 	* title
 		* GameObject
 		* group of all components that show the title screen
 		* can be set active to true or false
	* reset
		* GameObject
		* reset UI
		* set active to true when pressed to show player that a reset is occurring
	* resetSound
		* AudioClip
		* sound played when reset occurs
	* source
		* AudioSource
		* accesses audio component
	* DeleteScore()
		* return void
		* deletes all player prefs (scores stored) when button is pressed
		* accesses Resetting() to load reset UI
	* Resetting()
		* IEnumerator
		* sets displays active and false for 3 seconds
		* shows player that a reset is happening
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	//variables
	public GameObject title;
	public GameObject reset;

	public AudioClip resetSound;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DeleteScore()
	{
		PlayerPrefs.DeleteAll();
		StartCoroutine(Resetting());
	}

	IEnumerator Resetting() 
	{
		source.PlayOneShot(resetSound, 1f);
		title.SetActive(false);
		reset.SetActive(true);
		yield return new WaitForSeconds(1.5f);
		reset.SetActive(false);
		title.SetActive(true);
	}

}


