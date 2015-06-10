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

    private eNPCState currentState = eNPCState.Disabled;

    void Start()
    {
        if (currentState == eNPCState.Disabled)
        {
            Respawn();
        }
    }

    void Update()
    {
        if (currentState == eNPCState.Disabled)
            Start();

        if (health <= 0)
        {
            Explode();
            currentState = eNPCState.Disabled;
        }
    }

    void Explode()
    {

    }

    void Respawn()
    {
        health = 1;
        xpos = Random.Range(GameManager.Singleton().GetWorldLeft(), GameManager.Singleton().GetWorldTop());
        zpos = GameManager.Singleton().GetWorldTop();
        transform.position = new Vector3(xpos, 0.0f, zpos);
    }
}