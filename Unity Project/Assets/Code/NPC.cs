using UnityEngine;
using System.Collections;

public class NPC : Character
{
    private int health, speed;
    private float xpos, zpos = 0;
    private bool isDead;

	void Start() 
    {
        isDead = false;
        health = 1;
        xpos = Random.Range(GameManager.Singleton().GetWorldBottomLeft(), GameManager.Singleton().GetWorldTopRight());
        transform.position = new Vector3(xpos, 0.0f, zpos);

	}
	
    void Update() 
    {
        if (isDead)
        {
<<<<<<< HEAD
            return;
=======
            
>>>>>>> e73de789e4fa0e0e8704550c5a362de4891b28a1
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
