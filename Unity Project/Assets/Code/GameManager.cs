using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour 
{
    // -------------------------------------
    // ------------- VARIABLES -------------
    // -------------------------------------
 
    public enum eGameState
    {
        eGameStateReady,
        eGameStateActive,
        eGameStateGameOver
    };
    
    private eGameState          currentState;
    
    // these are used to calculate the game world dimensions
    public Transform            bottomLeftAnchorPoint;
    public Transform            topRightAnchorPoint;

	private float               worldTop, worldBottom;
	private float               worldLeft, worldRight;
	private float               worldWidth;
	private float               worldHeight;

    private float               gameSpeed;      // this is used for the background scrolling speed and the player movement
    private float               countdown;
    private float               countdownStart;

    private Player[]            players;
    private List<Entity>        activeEntities;
    private List<Entity>        inactiveEntities;

	private float				delayBeforeEntitySpawn;				// this var holds the counting down time
	private const float			delayBeforeEntitySpawnTime = 0.25f;	// this var holds the number which the other uses when reset

	public List<GameObject>		backgrounds;
	public List<Entity>			entityList;

    private int                 numActivePlayers;


    // -------------------------------------
    // ------------- SINGLETON -------------
    // -------------------------------------

    static private GameManager gm;             // singleton!
    public static GameManager Singleton()
    {
        if (!gm)
        {
            gm = FindObjectOfType<GameManager>();
        }

        return gm;
    }
    
    // ---------------------------------------------
    // ------------- ACCESSOR FUNCTIONS ------------
    // ---------------------------------------------

	public float GetWorldTop() { return worldTop; }
	public float GetWorldBottom() { return worldBottom; }
	public float GetWorldLeft() { return worldLeft; }
	public float GetWorldRight() { return worldRight; }
	public float GetWorldWidth() { return worldWidth; }
	public float GetWorldHeight() { return worldHeight; }


    // ---------------------------------------
    // ------------- GM FUNCTIONS ------------
    // ---------------------------------------

	void Start ()
    {
		// setup the singleton! this is vital!
		gm =				this;

		// create lists
		activeEntities =	new List<Entity>();
		inactiveEntities =	new List<Entity>();
		
        // get all players
        players =           FindObjectsOfType<Player>();
        
        //  10 second countdown
        countdownStart =    10.0f;

		gameSpeed =			1.0f;

        // setup world extents
        worldTop =          topRightAnchorPoint.position.z;
        worldBottom =       bottomLeftAnchorPoint.position.z;
        worldLeft =         bottomLeftAnchorPoint.position.x;
        worldRight =        topRightAnchorPoint.position.x;

        // get world dimensions
        worldWidth =        worldRight - worldLeft;
        worldHeight =       worldTop - worldBottom;

		/*
		print( "world top " + worldTop );
		print( "world bottom " + worldBottom );
		print( "world left " + worldLeft );
		print( "world right " + worldRight );
		print( "world height " + worldHeight );
		print( "world width " + worldWidth );
		*/

        // setup the game
	    ChangeState(eGameState.eGameStateReady);
		delayBeforeEntitySpawn = 0.3f;
	}	

	void FixedUpdate ()
    {
        // return to main menu on escape press
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("MainMenu");

        numActivePlayers = GetNumPlayers();
		
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

		UpdateBackground();

		if ( inactiveEntities.Count + activeEntities.Count < GetDifficultyInEntities() )
		{			
            CreateEntity();
		}

		if ( activeEntities.Count < GetDifficultyInEntities() )
		{
			delayBeforeEntitySpawn -= Time.deltaTime;

			if ( delayBeforeEntitySpawn <= 0.0f )
			{
				ActivateEntity();
				delayBeforeEntitySpawn = delayBeforeEntitySpawnTime;
			}
		}

        // update active entities
        if (activeEntities.Count > 0)
        {
            foreach (Entity entity in activeEntities)
            {
                // move entitiy down the screen relative to the game speed
                entity.transform.position -= Vector3.forward * gameSpeed * Time.deltaTime;

                if (entity.transform.position.z < GetDestructionLineZ())
                {
                    DeactivateEntity(entity);
                }
            }
        }

		// move player down screen
		foreach ( Player player in players )
		{
            if (player.GetState() != Player.ePlayerState.ePlayerStateInactive)
            {
                // move player down the screen relative to the game speed
                player.transform.position -= Vector3.forward * gameSpeed * Time.deltaTime;
            }
		}
    }

    private void UpdateGameOver()
    {
        // switch state when countdown reaches zero
        if ((countdown -= Time.deltaTime) < 0)
        {
            Application.LoadLevel("MainMenu");
        }
    }

    private void ChangeState(eGameState state)
   { 
        // early out if nothing has changed
        if (state == currentState)
            return;

		currentState = state;

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
		// clear entity lists
		activeEntities.Clear();
		inactiveEntities.Clear();
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

	// override
	private void ActivateEntity()
	{
		ActivateEntity( inactiveEntities[ Random.Range( 0, inactiveEntities.Count - 1 ) ] );
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

    private Entity CreateEntity()
    {        
		// early out if list is empty
        if (entityList.Count == 0)
            return null;

		// pick a random entity
		int random = Random.Range( 0, entityList.Count - 1 );

		// this is placeholder, real values will be needed
		Entity entity = Instantiate( entityList[random], GetWorldCentre(), Quaternion.identity ) as Entity;

		// add entity to inactive list
		inactiveEntities.Add( entity );

		return entity;
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
        return worldBottom - (worldHeight * 3.0f);
    }

	private void UpdateBackground()
	{
		foreach ( GameObject background in backgrounds )
		{
			background.transform.position -= new Vector3( 0.0f, 0.0f, gameSpeed * Time.deltaTime );

			if ( background.transform.position.z <= GetDestructionLineZ() )
			{
				background.transform.position += new Vector3( background.transform.position.x, background.transform.position.y, background.renderer.bounds.size.z * 3.0f );
			}
		}
	}

	private int GetDifficultyInEntities()
	{
		// this is pretty basic right now!
		// TODO: make this a little more advanced...
		return 2 + numActivePlayers;
	}
}
