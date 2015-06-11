using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class HudStuff : MonoBehaviour 
{
    public GUIText guiScore;
    public GUIText guiLives;
    public GUIText playerNumber;
    public GUIText pressStart;
      
    public Player player;

    private int score = 0;    
 
    private bool blinking = true;
	
	void Start () 
    {
        guiScore.text = "Score: 0";
        guiLives.text = "Lives: 3";
       
        StartCoroutine(Blink());
       
	}
	
	
	void Update ()
    {
        guiLives.guiText.enabled = player.IsActive();
        guiScore.guiText.enabled = player.IsActive();
        pressStart.guiText.enabled = !player.IsActive();
        
        if (player.IsActive())
        {
            guiScore.text = "Score: " + player.GetScore();
            guiLives.text = "Lives: " + player.GetLives();
            playerNumber.text = "Player ";
            blinking = false;//turn off blinking
           
        }

    }



   public IEnumerator Blink()// the code to blink player start text
    {
        while (blinking)
        {
            pressStart.text = "";//don't show
            yield return new WaitForSeconds(0.5f);
            pressStart.text = "Press Start";//show
            yield return new WaitForSeconds(0.5f);
        }
    }
   
        
        
}
    
 
  
       

        
    

   
   

