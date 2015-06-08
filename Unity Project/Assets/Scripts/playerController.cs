//Last edited by James Davidson
//08.06.2015
//playerController.cs

using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{	
	public float speed;
	
	
	void FixedUpdate () 
    {		
		//Assign and update the movement values. Yo.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Store the movement in a vector3. X, Y & Z. We don't move up on the Y axis so set to 0.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		transform.forward = rigidbody.velocity;


	
		//Add the force to the rigid body, depending on the speed.
		rigidbody.AddForce (movement * speed);
    }
}
