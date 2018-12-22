/*Rielle Dizon
 * 2282971
 * dizon110@mail.chapman.edu
 * CPSC 236-02
 * Final Project
 
 * Jump OverView
 	* Component of player
 	* Lets player jump with the use of the spacebar
 	* Limits jump to one press of the spacebar
 	* Plays sound everytime spacebar is pressed

 * Functions/Variables
 	* jumpSpeed
 		* float
 		* speed which the player jumps
	* isFalling
		* bool
		* checks if the player is on the ground or not
	* rb
		* Rigidbody
		* accesses player's rigidbody component
	* jumpSound
		* AudioClip
		* sound played when jump occurs
	* source
		* AudioSource
		* accesses component of player
*/

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class Jump : MonoBehaviour
{
	//variables
	public float jumpSpeed = 350.0f;
	private bool isFalling = false; 

	Rigidbody rb;

	public AudioClip jumpSound;
	private AudioSource source;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		source = GetComponent<AudioSource>();
	}


	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("space") && !isFalling) 
		{
			isFalling = true;
			rb.AddForce(Vector3.up * jumpSpeed);
			source.PlayOneShot(jumpSound, 1f);
		}

		if (isFalling && rb.transform.position.y <= -3.32)//based on position in inspector after first jump (lower than initial position)
		{
			isFalling = false;
		}
	}

}