/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * GameManger OverView
 	* Manages the obstacles instantiated and their speeds
 	* It also initializes the instruction screen. 
 
 * Functions/Variables
 	* speed
 		* float
 		* speed of obstacles that are increased periodically in Score.cs
	* instructionGO
		* GameObject
		* instruction text that is active for 5 seconds
		* Destroyed in Start()
	* instantiatedObstacle
		* GameObject array
		* obstacle groups with tag "Respawn" found during runTime
	* MoveObstacles()
		* returns void
		* moves obstacles based on speed
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//variables
	public float speed = 4.5f;
	public GameObject instructionGO;
	public GameObject [] instantiatedObstacle;

	// Use this for initialization
	void Start () {
		Destroy(instructionGO, 5); //destroys instruction UI after 5 seconds
	}
	
	// Update is called once per frame
	void Update () {
		MoveObstacles(); //checks speed every frame incase of a change
	}

	public void MoveObstacles()
	{
		instantiatedObstacle = GameObject.FindGameObjectsWithTag("Respawn"); //creates array of obstacles from Prefabs
		foreach (GameObject obstacle in instantiatedObstacle) //applies speed to all 
		{
			obstacle.transform.Translate(-speed * Time.deltaTime, 0, 0); //-speed to move left
		}
	}
}
