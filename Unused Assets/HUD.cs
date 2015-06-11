/*
	File:			HUD.cs
	Author:			Krz
	Project:		Ship Game
	Soundtrack:		Fnoob Techno Radio
	Description:	Manages the HUD elements of the game.
*/

using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
    // -------------------------------------
    // ------------- VARIABLES -------------
    // -------------------------------------

    private GUIText infoDisplay;                                                    // display of info
    public GUIText scoreDisplay;                                                    // display of current score
    public GUIText highScoreDisplay;                                                // display of high score
    private float infoTimer;                                                        // duration game info has been displayed for
    private static float DISPLAY_DURATION = 3f;                                     // how long the msg should be shown on screen for
    private static float FADE_DURATION = 1f;                                        // how long the msg takes to fade away
    private float fadeDurationRecip = 0f;
    private int infoCounter;                                                        // counts up mostly (each update) this will be used to create a fading effect using a sinewave and this value (cap above 0.5 fade)
        
    // -------------------------------------
    // ------------- SINGLETON -------------
    // -------------------------------------

    private static HUD hud;
    public static HUD Singleton()
    {
        if (!hud)
        {
            hud = FindObjectOfType<HUD>();
        }

        return hud;
    }

    // ---------------------------------------------
    // ------------- STANDARD FUNCTIONS ------------
    // ---------------------------------------------

    // Use this for initialization
	void Awake () {
        infoDisplay = GameObject.FindGameObjectWithTag("DebugInfo").GetComponent<GUIText>();
        fadeDurationRecip = 1f / FADE_DURATION;
	}
	
	void Update () {
        // increase counters and timers
        infoCounter++;
        if (infoCounter >= 1000) { infoCounter = 0; }
        infoTimer += Time.deltaTime;

        UpdateDisplay();

        // updates scores (disables them if the game state is waiting)
        UpdateScores(GameManager.GetGameState() != GameManager.eGameState.eWaiting);
	}

    private void UpdateDisplay() {
        // check if display is enabled and has something to show
        if ((infoDisplay) && (infoDisplay.text != "")) {
            if (infoTimer > DISPLAY_DURATION) {
                // if timer is past the duration
                DisplayInfo("");
            } else if (infoTimer > (DISPLAY_DURATION - FADE_DURATION)) {
                // if timer is between fade time and expire time
                float infoFadePercent = (infoTimer - (DISPLAY_DURATION - FADE_DURATION) * fadeDurationRecip);
                Color infoColour = infoDisplay.color;
                infoColour.a = (1f - infoFadePercent);
                infoDisplay.color = infoColour;
            }
        }
    }

    private void UpdateScores(bool enabled) {
        if (!scoreDisplay) { Awake(); }

        if (enabled) {
            // update scores
            scoreDisplay.guiText.text = "SCORE: " + Player.Singleton().GetScore().ToString();
            highScoreDisplay.guiText.text = "HIGH SCORE: " + GameManager.Singleton().highScore.ToString();
        }

        scoreDisplay.guiText.enabled = enabled;
        highScoreDisplay.guiText.enabled = enabled;
    }


    // ----------------------------------------
    // ------------- HUD FUNCTIONS ------------
    // ----------------------------------------

    public void DisplayInfo(string text)
    {
        DisplayInfo(text, false);
    }

    public void DisplayInfo(string text, bool permanent)
    {
        if (!infoDisplay) { Awake(); }
        // reset alpha to full
        Color infoColour = infoDisplay.color;
        infoColour.a = 1f;
        infoDisplay.color = infoColour;

        // scale size by the messege length
        if (text.Length < 6) {
            infoDisplay.transform.localScale = new Vector3(0.05f, 0.1f, 1f);
        } else {
            infoDisplay.transform.localScale = new Vector3(0.03f, 0.06f, 1f);
        }

        if (permanent) {
            // set timer to a huge negative number so the timer doesnt expire
            infoTimer = -9999f;
        } else {
            // reset timer
            infoTimer = 0f;
        }

        // display text
        infoDisplay.guiText.text = text;
    }
}
