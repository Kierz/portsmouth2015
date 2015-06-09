using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour 
{
    public enum eGameState
    {
        eGameStateReady,
        eGameStateActive,
        eGameStateGameOver
    };

    static private GameManager  gm;             // singleton!

    private eGameState          currentState;
    
    // these are used to calculate the game world dimensions
    public Transform            bottomLeftAnchorPoint;
    public Transform            topRightAnchorPoint;

    public float                worldTop, worldBottom;
    public float                worldLeft, worldRight;
    public float                worldWidth;
    public float                worldHeight;

    private float               gameSpeed;      // this is used for the background scrolling speed and the player movement
    private float               countdown;
    private float               countdownStart;

    private Player[]            players;
    private List<Entity>        activeEntities;
    private List<Entity>        inactiveEntities;

	public List<GameObject>		backgrounds;

    private int                 numActivePlayers;

    // singleton!!!
    public static GameManager Singleton() { return gm; }

	// quick accessor functions
	public float GetWorldTop() { return worldTop; }
	public float GetWorldBottom() { return worldBottom; }
	public float GetWorldLeft() { return worldLeft; }
	public float GetWorldRight() { return worldRight; }
	public float GetWorldWidth() { return worldWidth; }
	public float GetWorldHeight() { return worldHeight; }


	void Start ()
    {
        // get all players
        players =           FindObjectsOfType<Player>();
        
        //  10 second countdown
        countdownStart =    10.0f;             

        // setup world extents
        worldTop =          topRightAnchorPoint.position.y;
        worldBottom =       bottomLeftAnchorPoint.position.y;
        worldLeft =         bottomLeftAnchorPoint.position.x;
        worldRight =        topRightAnchorPoint.position.x;

        // get world dimensions
        worldWidth =        worldRight - worldLeft;
        worldHeight =       worldTop - worldBottom;

        // setup the game
	    ChangeState(eGameState.eGameStateReady);
	}	

	void Update ()
    {
        numActivePlayers = GetNumPlayers();

		UpdateBackground();

        switch (currentState)
        {
            case eGameState.eGameStateReady:
                UpdateReady();
                break;

            case eGameState.eGameStateActive:
                UpdateActive();
                break;

            case eGameState.eGameStateGameOver:
                UpdateGameOver();
                break;
        }
	}

    private void UpdateReady()
    {
        if (numActivePlayers > 0)
        {
            ChangeState(eGameState.eGameStateActive);
            return;
        }
    }

    private void UpdateActive()
    {
        if (numActivePlayers == 0)
        {
            ChangeState(eGameState.eGameStateGameOver);
            return;
        }

        // update active entities
        foreach (Entity entity in activeEntities)
        {
            // move player down the screen relative to the game speed
            entity.transform.Translate(Vector3.forward * -1 * Time.deltaTime);

            if (entity.transform.position.z < GetDestructionLineZ())
            {
                DeactivateEntity(entity);
            }
        }
    }

    private void UpdateGameOver()
    {
        // switch state when countdown reaches zero
        if ((countdown -= Time.deltaTime) < 0)
        {
            ChangeState(eGameState.eGameStateReady);
        }
    }

    private void ChangeState(eGameState state)
    {
        // early out if nothing has changed
        if (state == currentState)
            return;

        switch (state)
        {
            case eGameState.eGameStateReady:
                ResetGame();
                break;

            case eGameState.eGameStateActive:

                break;

            case eGameState.eGameStateGameOver:
                countdown = countdownStart;
                break;
        }
    }

    private void ResetGame()
    {

    }

    private int GetNumPlayers()
    {
        int playerCount = 0;

        foreach (Player player in players)
        {
            if (player.GetState() != Player.ePlayerState.ePlayerStateInactive)
                playerCount++;
        }

        return playerCount;
    }

    private eGameState GetGameState()
    {
        return currentState;
    }

    private void ActivateEntity(Entity entity)
    {
        // early out if already active
        if (activeEntities.Contains(entity))
            return;

        inactiveEntities.Remove(entity);
        activeEntities.Add(entity);
    }

    private void DeactivateEntity(Entity entity)
    {
        // early out if already inactive
        if (inactiveEntities.Contains(entity))
            return;

        activeEntities.Remove(entity);
        inactiveEntities.Add(entity);
    }

    private void CreateEntity()
    {

    }

    private string GetCoundownAsString()
    {
        int displayCountdown = (int)Mathf.Floor(countdown) + 1;

        return displayCountdown.ToString();
    }

    public Vector3 GetWorldCentre()
    {
        return Vector3.Lerp(bottomLeftAnchorPoint.position, topRightAnchorPoint.position, 0.5f);
    }

    public float GetDestructionLineZ()
    {
        return worldBottom - (worldHeight * 0.5f);
    }

	private void UpdateBackground()
	{
		foreach ( GameObject background in backgrounds )
		{
			background.transform.Translate( 0.0f, 0.0f, gameSpeed * Time.deltaTime );
			
			if ( background.transform.position.z <= GetDestructionLineZ() )
			{
				background.transform.position += new Vector3( background.transform.position.x, background.transform.position.y, background.renderer.bounds.extents.y * 2.0f );
			}
		}
	}
}
