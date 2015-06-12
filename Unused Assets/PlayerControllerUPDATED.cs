//Last edited by James Davidson
//09.06.2015
//playerController.cs

using UnityEngine;
using System.Collections;

public class PlayerControllerUPDATED : MonoBehaviour
{
    public float speed, rotationSpeed;
    private float dirHorizontal, dirVertical, moveHorizontal, moveVertical, invincibilityTime;
    public int joyStick;

    public enum InputType { Keyboard, Controller };

    //Assume default input is keyboard unless specified in the inspector for the Player object.
    public InputType m_inputType;

    void Start()
    {
        speed = 100.0f;
        rotationSpeed = 360.0f;         // 360 degrees rotation per second
        invincibilityTime = 2.0f;
    }

    void FixedUpdate()
    {
        Movement();
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
        if (col.gameObject.tag == "Slow")
        {
            speed *= 2;
        }
    }

    void Movement()
    {
        //Retrieve the joystick number. Then string concatenates the number on the end.
        //This is so we can split up which controller is being used on input
        string joystickString = joyStick.ToString();

        if (m_inputType == InputType.Controller)
        {
            dirHorizontal = Input.GetAxis("JoyStickR Horizontal_P" + joystickString);
            dirVertical = Input.GetAxis("JoyStickR Vertical_P" + joystickString);
            moveHorizontal = Input.GetAxis("JoyStickL Horizontal_P" + joystickString);
            moveVertical = Input.GetAxis("JoyStickL Vertical_P" + joystickString);
        }
        else if (m_inputType == InputType.Keyboard)
        {
            dirHorizontal = rigidbody.velocity.x;
            dirVertical = rigidbody.velocity.z;
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }

        //Store the movement in a vector3. X, Y & Z. We don't move up on the Y axis so set to 0.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 direction = new Vector3(dirHorizontal, 0.0f, dirVertical);

        //if (rigidbody.velocity.magnitude > 0.01f)
        {
            // store current rotation
            Quaternion currentRotation = transform.rotation;

            // point object at intended facing direction
           // transform.LookAt(new Vector3(transform.position.x + dirHorizontal, transform.position.y, transform.position.z + dirVertical));
            transform.LookAt(transform.position + direction);
            // lerp from current rotation to intended facing direction
            transform.rotation = Quaternion.RotateTowards(currentRotation, transform.rotation, Time.deltaTime * rotationSpeed);
        }

        //Add the force to the rigid body, depending on the speed.
        //rigidbody.AddForce(movement * speed);

        transform.position += (movement * speed * Time.deltaTime);
    }
    
}