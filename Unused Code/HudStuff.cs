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

    public SpriteRenderer Life1;
    public SpriteRenderer Life2;
    public SpriteRenderer Life3;

    public Player player;
    private int livesRemaining;
    private int score = 0;    
 
    private bool blinking = true;
	
	void Start () 
    {
        //guiScore.text = "Score: 0";
        //guiLives.text = "Lives: ";
        Life1.renderer.enabled = false;
        Life2.renderer.enabled = false;
        Life3.renderer.enabled = false;
        StartCoroutine(Blink());
	}
	
	
	void Update ()
    {
        guiLives.guiText.enabled = player.IsActive();
        guiScore.guiText.enabled = player.IsActive();
        pressStart.guiText.enabled = !player.IsActive();
        
        if (player.IsActive())
        {
            guiScore.text = "Score: " +player.GetScore();
            guiLives.text = "Lives: " +player.GetLives();
            playerNumber.text = "Player ";


            blinking = false;//turn off blinking
            livesRemaining = player.GetLives();


            if (livesRemaining == 3)
            {
                Life1.renderer.enabled = true;
                Life2.renderer.enabled = true;
                Life3.renderer.enabled = true;
            }
            else
                if (livesRemaining ==2)
                {
                    Life1.renderer.enabled = true;
                    Life2.renderer.enabled = true;
                    Life3.renderer.enabled = false;
                }
                else
                    if (livesRemaining == 1)
                    {
                        Life1.renderer.enabled = true;
                        Life2.renderer.enabled = false;
                        Life3.renderer.enabled = false;
                    }//put death conditions below
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
    
 
  
       

        
    

   
   

