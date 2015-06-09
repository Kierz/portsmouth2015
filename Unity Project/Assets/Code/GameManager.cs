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

    public eGameState           currentState;

    private float               gameSpeed;      // this is used for the background scrolling speed and the player movement
    private float               countdown;
    private float               countdownStart;

    private List<Player>        players;
    private List<Entity>        activeEntities;
    private List<Entity>        inactiveEntities;

    // singleton!!!
    static GameManager Singleton() { return gm; }


	void Start ()
    {
        countdownStart = 10.0f;             //  10 second countdown

        // setup the game
	    ChangeState(eGameState.eGameStateReady);
	}	

	void Update ()
    {
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


    }

    private void UpdateActive()
    {
        int numPlayers = GetNumPlayers();

        if (numPlayers == 0)
        {
            ChangeState(eGameState.eGameStateGameOver);
            return;
        }


    }

    private void UpdateGameOver()
    {
        // switch state when countdown reaches 0
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
            if (player.GetState() == Player.ePlayerState.ePlayerStateActive)
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
}
