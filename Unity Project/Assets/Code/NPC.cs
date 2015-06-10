using UnityEngine;
using System.Collections;

public class NPC : Character
{
    public int health, speed;
    private float xpos, zpos = 0;
    private bool isDead;

    public enum eNPCState
    {
        Active,
        Disabled
    }

    private eNPCState currentState;

    void Start()
    {
        if (currentState == eNPCState.Active)
        {
            isDead = false;
            health = 1;
            //xpos = Random.Range(left, right);
            transform.position = new Vector3(xpos, 0.0f, zpos);
        }
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