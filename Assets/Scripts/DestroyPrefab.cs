/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * DestroyPrefab OverView
 	* Component of ExitTrigger
 	* Destroys the group of obstacles when trigger is hit offscreen

 * Functions/Variables
 	* spawnPoint
 		* GameObject
 		* empty box collider that is used to respawn objects on the opposite side of the ExitTrigger
	* OnTriggerEnter()
		* returns void
		* paramater checks if the object that enters the ExitTrigger is another collider
		* in this case, the obstacle Prefab with the tag "Respawn"
		* accesses InstantiatePrefab() within spawnPoint to spawn a randomized obstacle
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
	public GameObject spawnPoint;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Respawn")
		{
			Destroy(other.gameObject,5); //destroys after 5 seconds to prevent a "lag" in obstacles; makes it seem continuous
			spawnPoint.GetComponent<InstantiatePrefab>().SpawnObstacle(); 
		}

	}

}
