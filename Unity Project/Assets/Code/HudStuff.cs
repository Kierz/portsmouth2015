using UnityEngine;
using System.Collections;



public class HudStuff : MonoBehaviour 
{
    public GUIText guiScore;
    public GUIText guiLives;
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
        guiScore.text = "Score: " + player.GetScore();
	}

   
}
