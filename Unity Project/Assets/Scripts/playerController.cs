//Last edited by Kierz Phillips
//08.06.2015
//playerController.cs

using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{	
	private float speed;
    private float rotationSpeed;

    void Start()
    {

        speed = 100.0f;
        rotationSpeed = 360.0f;         // 360 degrees rotation per second
    }

	void FixedUpdate () 
    {		
		//Assign and update the movement values. Yo.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Store the movement in a vector3. X, Y & Z. We don't move up on the Y axis so set to 0.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        // only do this if we have a velocity
        if (rigidbody.velocity.magnitude > 0.01f)
        {
            // store current rotation
            Quaternion currentRotation = transform.rotation;

            // point object at intended facing direction
            transform.LookAt(new Vector3(transform.position.x + rigidbody.velocity.x, transform.position.y, transform.position.z + rigidbody.velocity.z));

            // lerp from current rotation to intended facing direction
            transform.rotation = Quaternion.RotateTowards(currentRotation, transform.rotation, Time.deltaTime * rotationSpeed);
        }

		//Add the force to the rigid body, depending on the speed.
		rigidbody.AddForce(movement * speed);
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Slow") 
		{
			//Halve the players speed when inside a trigger called slow.
			speed /= 2;
		}

		/*if (collision.gameObject.tag == "Kill") 
		{
			//Kill bat + game over
		}

		if (collision.gameObject.tag == "") 
		{
			
		}*/
	}
	
	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "Slow")
		{
			speed *= 2;
		}
	}
}

	
	
