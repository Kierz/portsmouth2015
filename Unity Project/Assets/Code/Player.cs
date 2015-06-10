using UnityEngine;
using System.Collections;

public class Player : Character 
{
    // -------------------------------------------------------------------------------------------
    public enum ePlayerState
    {
        ePlayerStateNormal,
        ePlayerStateInactive,
        ePlayerStateInvincible,
    };

    public enum eInputType 
    {
        eInputTypeKeyboard,
        eInputTypeController
    };
    
    // -------------------------------------------------------------------------------------------

    private int             lives;
    private ePlayerState    currentState;
    
    private float           speed;
    private float           speedFactor;
    private float           rotationSpeed;

    private float           invincibilityTime;

    public int              joystick;               // contains the player ID
    public eInputType       inputType;
    
    // -------------------------------------------------------------------------------------------

    public ePlayerState GetState() { return currentState; }
    
    // -------------------------------------------------------------------------------------------

	void Start ()
    {
        SetState(		        ePlayerState.ePlayerStateInactive);
        speed =                 20.0f;
        rotationSpeed =         360.0f;         // 360 degrees rotation per second
        invincibilityTime =     2.0f;
        speedFactor =           1.0f;
        lives =                 3;
	}
	
	void Update () 
    {
        switch (currentState)
        {
            case ePlayerState.ePlayerStateInactive:
                UpdateInactive();
                break;

            case ePlayerState.ePlayerStateNormal:
                Move();
				UpdateFire();
                break;

            case ePlayerState.ePlayerStateInvincible:
                invincibilityTime -= Time.deltaTime;

                if (invincibilityTime <= 0)
                {
                    SetState(ePlayerState.ePlayerStateNormal);
                }

                Move();
				UpdateFire();
                break;
        }
	}

    private void UpdateInactive()
    {
        if (inputType == eInputType.eInputTypeController)
        {
            //Game waits for player to press start before bat control is authorised
			if ( Input.GetButtonDown( "Start_P" + joystick.ToString() ) )
				Respawn();
        }
        else
        {
            if (Input.GetButtonDown("Submit"))
				Respawn();
        }
    }

	private void UpdateFire()
	{
		string joystickString = joystick.ToString();

		if ( Input.GetKeyDown( KeyCode.Space ) || Input.GetButtonDown( "Fire_P" + joystick.ToString() ) )
		{
			Fire( transform.position, transform.rotation );
		}
	}

    private void Move()
    {
        float dirHorizontal, dirVertical, moveHorizontal, moveVertical;

        //Retrieve the joystick number. Then string concatenates the number on the end.
        //This is so we can split up which controller is being used on input
        string joystickString = joystick.ToString();

        if (inputType == eInputType.eInputTypeController)
        {
            dirHorizontal = Input.GetAxis("JoyStickR Horizontal_P" + joystickString);
            dirVertical = Input.GetAxis("JoyStickR Vertical_P" + joystickString);
            moveHorizontal = Input.GetAxis("JoyStickL Horizontal_P" + joystickString);
            moveVertical = Input.GetAxis("JoyStickL Vertical_P" + joystickString);
        }
        else
        {
            dirHorizontal = rigidbody.velocity.x;
            dirVertical = rigidbody.velocity.z;
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }

        //Store the movement in a vector3. X, Y & Z. We don't move up on the Y axis so set to 0.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 direction = new Vector3(dirHorizontal, 0.0f, dirVertical);

        // store current rotation
        Quaternion currentRotation = transform.rotation;

        // point object at intended facing direction
        transform.LookAt(transform.position + direction);

        // lerp from current rotation to intended facing direction
        transform.rotation = Quaternion.RotateTowards(currentRotation, transform.rotation, Time.deltaTime * rotationSpeed);

		Vector3 newPosition = transform.position + ( movement * speed * speedFactor * Time.deltaTime );

		//if ( !IsOffScreen( newPosition ) )		this was awfull, dont use it!
		{
			transform.position = newPosition;
		}
    }

    private void Respawn()
    {
        transform.position = GameManager.Singleton().GetWorldCentre();

        invincibilityTime = 2.0f;
		SetState(ePlayerState.ePlayerStateInvincible);
    }
    
    private void PlayerDeath()
    {
        if (--lives <= 0)
        {
            SetState(ePlayerState.ePlayerStateInactive);
        }
    }
    
    // -------------------------------------------------------------------------------------------

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Slow")
        {
            //Halve the players speed when inside a trigger called slow.
            speedFactor = 0.5f;
        }

        if (col.gameObject.tag == "Kill") 
        {
			// respawn player if they have enough lives left, if not gameover
            PlayerDeath();
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Slow")
        {
            speedFactor = 1.0f;
        }
    }

	private bool IsOffScreen(Vector3 position)
	{
		/*
		if ( position.x < GameManager.Singleton().GetWorldLeft() )
			return true;

		if ( position.x > GameManager.Singleton().GetWorldRight() )
			return true;

		if ( position.z > GameManager.Singleton().GetWorldTop() )
			return true;

		if ( position.z < GameManager.Singleton().GetWorldBottom() )
			return true;
		*/

		// this was awfull do not use it.. feel free to recode this =]

		return false;
	}

	private void SetState( ePlayerState state )
	{
		// early out if no change
		if ( currentState == state )
			return;

		currentState = state;

		switch ( state )
		{
			case ePlayerState.ePlayerStateInactive:
			transform.position = new Vector3( 999, 999, 999 );


			break;

			case ePlayerState.ePlayerStateInvincible:

			break;

			case ePlayerState.ePlayerStateNormal:

			break;

		}
	}

}