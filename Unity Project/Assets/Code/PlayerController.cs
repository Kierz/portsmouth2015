//Last edited by James Davidson
//09.06.2015
//playerController.cs

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{	
	private float speed;
    private float rotationSpeed;
    public int joyStick;

    private float moveHorizontal;
    private float moveVertical;

    public enum InputType {Keyboard, Controller};

    //Assume default input is keyboard unless specified in the inspector for the Player object.
    //Could make this so it's manually detected.... but hey! ;(
    public InputType m_State = InputType.Keyboard; 

    void Start()
    {
        speed = 100.0f;
        rotationSpeed = 360.0f;         // 360 degrees rotation per second
    }

	void FixedUpdate () 
    {		
		//Assign and update the movement values. Yo.
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");

        //Store the movement in a vector3. X, Y & Z. We don't move up on the Y axis so set to 0.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        RotateDirection(m_State);

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

    void RotateDirection(InputType input)
    {

        float dirHorizontal;
        float dirVertical;

        if(input == InputType.Controller)
        {
            //Retrieves which JoyStick is being used. So Joystick 1. Etc, etc.
            string joystickString = joyStick.ToString();

            //Assign controller axis'
           dirHorizontal = Input.GetAxis("JoyStick Horizontal_P" + joystickString);
           dirVertical = Input.GetAxis("JoyStick Vertical_P" + joystickString);
        }
        else if(input == InputType.Keyboard)
        {
            dirHorizontal = rigidbody.velocity.x;
            dirVertical = rigidbody.velocity.z;
        }

        // store current rotation
        Quaternion currentRotation = transform.rotation;

        // point object at intended facing direction
        transform.LookAt(new Vector3(transform.position.x + rigidbody.velocity.x, transform.position.y, transform.position.z + rigidbody.velocity.z));

        // lerp from current rotation to intended facing direction
        transform.rotation = Quaternion.RotateTowards(currentRotation, transform.rotation, Time.deltaTime * rotationSpeed);

    }
}

	
	
