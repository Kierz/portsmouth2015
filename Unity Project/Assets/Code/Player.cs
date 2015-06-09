using UnityEngine;
using System.Collections;

public class Player : Character 
{
    public enum ePlayerState
    {
        ePlayerStateActive,
        ePlayerStateInactive,
        ePlayerStateInvincible,
    };

    private ePlayerState currentState;


    public ePlayerState GetState() { return currentState; }


	void Start ()
    {
        currentState = ePlayerState.ePlayerStateInactive;
	}
	
	void Update () 
    {
	
	}
}
