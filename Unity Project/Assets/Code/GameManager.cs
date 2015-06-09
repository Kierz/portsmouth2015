using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour 
{
    enum eGameState
    {
        eGameStateReady,
        eGameStateActive,
        eGameStateGameOver
    };

    static private GameManager  gm;             // singleton!

    public eGameState           currentState;

    private float               gameSpeed;      // this is used for the background scrolling speed and the player movement
    private float               countdown;

    private List<Player>        players;
    private List<Entity>        activeEntities;
    private List<Entity>        inactiveEntities;

	void Start ()
    {
        // setup the game
	    ChangeState(eGameState.eGameStateReady);
	}	

	void Update ()
    {
	
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
}
