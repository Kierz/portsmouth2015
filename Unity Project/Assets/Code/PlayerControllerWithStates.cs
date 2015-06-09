//Last edited by Matt Moore
//09.06.2015
//playerControllerWithStates.cs

using UnityEngine;
using System.Collections;

public class PlayerControllerWithStates : MonoBehaviour {

	//Player states:
	//Inactive = Player is disabled.
	//Normal = Player is active.
	//Invincible = Player is invincible.

	public enum ePlayerState {ePlayerStateInactive, ePlayerStateNormal, ePlayerStateInvincible};

	//Initial state is Inactive.
	public ePlayerState currentState = ePlayerState.ePlayerStateInactive;
	
	private float speed;
	private float rotationSpeed;
	private float invincibilityTime;

    public int joystick;

	void Start()
	{
		speed = 100.0f;
		rotationSpeed = 360.0f;         // 360 degrees rotation per second
		invincibilityTime = 2.0f;
	}

	void NormalUpdate()
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
		if (currentState == ePlayerState.ePlayerStateNormal)
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
	}
	
	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "Slow")
		{
			speed *= 2;
		}
	}
	
	void InvincibleUpdate()
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
		
		invincibilityTime -= Time.deltaTime;
		
		if(invincibilityTime <= 0)
		{
			currentState = ePlayerState.ePlayerStateNormal;
			invincibilityTime = 2.0f;
		}
	}
	
	void FixedUpdate () 
	{
		switch (currentState) 
		{
		case ePlayerState.ePlayerStateInactive:
		//ePlayerStateInactive START

			string joystickString = joystick.ToString();
			if(Input.GetButtonDown("Start_P" + joystickString) == true)
			{
				//Game waits for player to press start before bat control is authorised
                currentState = ePlayerState.ePlayerStateNormal;
			}
		
			break;
		//ePlayerStateInactive END

		case ePlayerState.ePlayerStateNormal:
		//ePlayerStateNormal START

			NormalUpdate ();

			break;
		//ePlayerStateNormal END

		case ePlayerState.ePlayerStateInvincible:
		//ePlayerStateInvincible START

			InvincibleUpdate();

			break;
		//ePlayerStateInvincible END
		}
	}
}
