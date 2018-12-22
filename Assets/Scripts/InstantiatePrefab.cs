/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * InstantiatePrefab OverView
 	* Component of spawnPoint
 	* loads a random obstacle group from a list of Prefabs and spawns it at a point opposite the ExitTrigger
 	* called from DestroyPrefab.cs

 * Functions/Variables
 	* obstacles
 		* GameObject List
 		* list of obstacle groups from Prefabs 
	*SpawnObstacle()
		* returns void
		* randomly instantiates an obstacle group from the list
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour {

	//variables
	public List<GameObject> obstacles;
	public GameObject spawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnObstacle()
	{
		Instantiate(obstacles[(Random.Range(0, obstacles.Count))], spawnPoint.transform.position, spawnPoint.transform.rotation);
	}
}
