//Last edited by James Davidson
//08.06.2015
//playerController.cs

using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		
		//Assign and update the movement values. Yo.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Store the movement in a vector3. X, Y & Z. We don't move up on the Y axis so set to 0.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		print ("Test 1 " + transform.rotation);

		transform.forward = rigidbody.velocity;

		print ("Test 2 " + transform.rotation);
	
		//Add the force to the rigid body, depending on the speed.
		rb.AddForce (movement * speed);

		//Lerp so that the player does not rotate too quickly
		//Vector3.Lerp(movement, Vector3, float rate): Vector3;
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Slow") 
		{
			//Halve speed
		}

		/*if (collision.gameObject.tag == "Kill") 
		{
			//Kill bat + game over
		}

		if (collision.gameObject.tag == "") 
		{
			
		}*/
	}
}