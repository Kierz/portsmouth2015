using UnityEngine;
using System.Collections;

public class NPC : Character
{
    private int health, speed, xpos, ypos;
    bool isDead;

    public GameManager gm;

	void Start() 
    {
        isDead = false;
        health = 1;
        xpos = Random.Range(((int)GameManager.Singleton().worldTop - (int)GameManager.Singleton().worldLeft), (int)GameManager.Singleton().worldTop);
	}
	
    void Update() 
    {
        if (isDead)
        {
            break;
        }

	    if(health <= 0)
        {
            explode();
            isDead = true;
        }
	}

    void explode()
    {

    }
}
