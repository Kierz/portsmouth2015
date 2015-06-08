/*
	File:			GameManager.cs
	Author:			Krz
	Project:		ShipGame
	Soundtrack:		Fnoob Techno Radio
	Description:	Manages the state of the game.
*/

using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    // -------------------------------------
    // ------------- VARIABLES -------------
    // -------------------------------------

    // prefabs
    public GameObject bulletObj;
    public GameObject scorePlumObj;
    public GameObject scorePlumBigObj;
    public GameObject scorePlumNegativeObj;
    public int highScore=0;

    // Cameras
    public Camera gameCamera;                                                       // holds the game camera
    public Camera voidCamera;                                                       // holds the void camera

    public static int COUNTDOWN_DURATION = 3;
    private int countDown = 0;
    public static float DELAY_TO_START_NEW_ROUND = 3f;

    
    // ---------------------------------
    // ------------- ENUMS -------------
    // ---------------------------------

    public enum eGameState
    {
        eWaiting = 0,
        eReady,
        eFighting,
        eGameOver
    }

    private eGameState gameState=eGameState.eGameOver;
    public static eGameState GetGameState() { return Singleton().gameState; }

    // -------------------------------------
    // ------------- SINGLETON -------------
    // -------------------------------------

    private static GameManager gm;
    public static GameManager Singleton()
    {
        if (!gm)
        {
            gm = FindObjectOfType<GameManager>();
        }

        return gm;
    }

    // ---------------------------------------------
    // ------------- STANDARD FUNCTIONS ------------
    // ---------------------------------------------

    void Awake() {
        // update high score
        RefreshHighScore();                     // keep this first

        // start the waiting game
        ChangeState(eGameState.eWaiting);       // keep this last
    }

    void Update() {
        // start game from waiting state
        if (GetGameState() == eGameState.eWaiting) {
            // check for touch screen input
            if (Input.touches.Length > 0) {
                if (Input.touches[0].phase == TouchPhase.Began) {
                    ChangeState(eGameState.eReady);
                }
            }

            // check for mouse clicks
            if (Input.GetMouseButton(0)) {
                ChangeState(eGameState.eReady);
            }
        }

        // exit game
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.LoadLevel("MainMenu");
        }
    }


    // ---------------------------------------
    // ------------- GN FUNCTIONS ------------
    // ---------------------------------------

    public void ChangeState(eGameState state) {
        // halt if given the same state twice
        if (gameState == state) { return; }

        // copy game state
        gameState = state;

        // disable all cameras
        gameCamera.enabled = false;
        voidCamera.enabled = false;
                
        switch (gameState) {
            case eGameState.eWaiting: {
                // show user nothing
                voidCamera.enabled = true;
                Player.Singleton().DisplayHealthBar(false);
                CleanUpBullets();
                ResetEnemySpeeds();

                // okay give them a quick msg
                DisplayInfo("Press anywhere to start!", true);

                break;
            }

            case eGameState.eReady: {
                // show game
                gameCamera.enabled = true;
                Player.Singleton().DisplayHealthBar(false);
                NewGame();

                // start the countdown
                countDown = COUNTDOWN_DURATION;
                StartCoroutine(Countdown());

                break;
            }

            case eGameState.eFighting: {
                // show user the game
                gameCamera.enabled = true;
                Player.Singleton().DisplayHealthBar(true);

                DisplayInfo("SHOOT THE SHIPS!");

                break;
            }

            case eGameState.eGameOver: {
                // show user the game
                gameCamera.enabled = true;
                Player.Singleton().DisplayHealthBar(true);
                
                // game over - pause time!
                DisplayInfo("GAMEOVER!");
                
                // update high score
                if (RefreshHighScore()) {
                    // if the high score was updated let the player know!
                    StartCoroutine(NewHighScore());

                    // return to ready screen automatically but a little longer than if there is no new high score
                    StartCoroutine(NewRound(DELAY_TO_START_NEW_ROUND + 2f));     // this will start the next round (including countdown)
                } else {
                    // return to ready screen automatically
                    StartCoroutine(NewRound(DELAY_TO_START_NEW_ROUND));     // this will start the next round (including countdown)
                }
                
                break;
            }
        }
    }
    
    private IEnumerator NewRound(float delay) {
        yield return new WaitForSeconds(delay);

        // switch to waiting state (waits for user to press a key)
        ChangeState(eGameState.eWaiting);
    }

    public static void DisplayInfo(string text)
    {
        DisplayInfo(text, false);
    }

    public static void DisplayInfo(string text, bool permanent)
    {
        HUD.Singleton().DisplayInfo(text, permanent);
    }
    
    private IEnumerator Countdown() {
        // display countdown
        DisplayInfo(countDown.ToString());

        // count down =]
        countDown--;

        // wait for a second
        yield return new WaitForSeconds(1);

        if (countDown == 0) {
            ChangeState(eGameState.eFighting);
        } else {
            StartCoroutine(Countdown());
        }
    }

    public void GameOver() {
        ChangeState(eGameState.eGameOver);
    }

    public void NewGame() {
        // respawn player
        Player.Singleton().Respawn();

        // respawn all enemies
        foreach (Enemy enemy in FindObjectsOfType<Enemy>()) {
            enemy.Respawn();
        }
    }

    public void CleanUpBullets() {
        // destroy all bullets
        foreach (Bullet bullet in FindObjectsOfType<Bullet>()) {
            DestroyObject(bullet);
        }
    }
    
    public void ResetEnemySpeeds() {
        // destroy all bullets
        foreach (Enemy enemy in FindObjectsOfType<Enemy>())
        {
            enemy.ResetSpeed();
        }
    }

    private bool RefreshHighScore() {
        highScore = GetHighScore();

        if (Player.Singleton().GetScore() > GetHighScore()) {
            SetHighScore(Player.Singleton().GetScore());

            // let them know if the high score was changed
            return true;
        }

        return false;
    }


    private int GetHighScore() {
        if (PlayerPrefs.HasKey("highscore")) {
            highScore = PlayerPrefs.GetInt("highscore");
            return highScore;
        } else {
            return 0;
        }
    }

    void SetHighScore(int highscore) {
        string key = "highscore";
        
        if (PlayerPrefs.HasKey(key)) {
            if (PlayerPrefs.GetInt(key) <= highscore) {
                PlayerPrefs.SetInt(key, highscore);
            } else {
                PlayerPrefs.SetInt(key, highscore);
            }
        }
        PlayerPrefs.Save();
    }

    IEnumerator NewHighScore() {
        yield return new WaitForSeconds(2);

        DisplayInfo("NEW HIGH SCORE!", true);
    }
}
