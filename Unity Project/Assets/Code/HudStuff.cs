using UnityEngine;
using System.Collections;



public class HudStuff : MonoBehaviour 
{
    public GUIText guiScore;
    public GUIText guiLives;
    public GUIText playerNumber;
    public GUIText pressStart;

    public Player player;
    private int score = 0;
    private int lives = 3;

	// Use this for initialization
	void Start () 
    {
        guiScore.text = "Score: 0";
        guiLives.text = "Lives: 3";        
         
	}
	
	// Update is called once per frame
	void Update ()
    {             
        guiLives.guiText.enabled = player.IsActive();
        guiScore.guiText.enabled = player.IsActive();
        pressStart.guiText.enabled = !player.IsActive();
        
        if (player.IsActive())
        {
            guiScore.text = "Score: " + player.GetScore();
            guiLives.text = "Lives: " + player.GetLives();
            playerNumber.text = "Player " ;
            pressStart.text = "Press Start";
        }
    }

   
}
