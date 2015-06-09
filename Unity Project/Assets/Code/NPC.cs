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
        xpos = Random.Range( GameManager.Singleton().GetWorldLeft(), GameManager.Singleton().GetWorldRight() );
        transform.position = new Vector3(xpos, 0.0f, zpos);

	}
	
    void Update() 
    {
        if (isDead)
            return;

	    if (health <= 0)
        {
            explode();
            isDead = true;
        }
    }

    void explode()
    {

    }
}
