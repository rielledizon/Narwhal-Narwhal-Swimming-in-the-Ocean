/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * LoadScene OverView
 	* Component of buttons
 	* Loads scene corresponding to the sceneName inputted in Unity

 * Functions/Variables
 	* sceneNameToLoad
 		* string
 		* scene name that matches scenes in build
	* LoadScene()
		* returns void
		* loads scene corresponding to the scene name inputted
	* DelayLoad()
		* IEnumerator
		* delays load of next scene to play sound of button
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	//variable
	public string sceneNameToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadSceneName(){
		StartCoroutine(DelayLoad());
	}

	IEnumerator DelayLoad()
	{
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene(sceneNameToLoad, LoadSceneMode.Single);
	}
}
