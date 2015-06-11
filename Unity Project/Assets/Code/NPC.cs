/*          File:       NPC.cs
            Project:    RaType
            Authors:    James Davidson
                        Matt Moore
            Purpose:    Game made for Portsmouh Game Jam 2015
 */
using UnityEngine;
using System.Collections;

public class NPC : Character
{
    // ---------------------------------
    // ------------- ENUMS -------------
    // ---------------------------------

    public enum eNPCState
    {
        Active,
        Disabled
    }

    public enum eEnemyType
    {
        Default,
        Pigeon,
        Crow
    }

    // -------------------------------------
    // ------------- VARIABLES -------------
    // -------------------------------------

    public int                      health;
    public int                      speed;              //Speed will be used for custom movement, not used currently.
    public int                      scoreValue;         // score given to player when destroyed

    private eNPCState               currentState;
    private eEnemyType              currentEnemy;
    private float                   xpos, zpos, ypos;
    protected float                 deltaTime;
    protected float                 creationZone;       // ypos of the creation zone
    
    // ------------------------------------------
    // ------------- NPC FUNCTIONS  -------------
    // ------------------------------------------

    void Start()
    {
        gameObject.tag =   "Enemy";
        speed =            0;
        xpos =             0;
        ypos =             0;
        zpos =             0;
        deltaTime =        0;
        currentState =     eNPCState.Disabled;
        currentEnemy =     eEnemyType.Default;
        creationZone =     GameManager.Singleton().GetCreationZone();
    }

    protected void Update()
    {
        if (currentState == eNPCState.Disabled)
        {
            int wait = Random.Range(2, 8);
            deltaTime += Time.deltaTime;
            if (deltaTime >= wait)
            {
                deltaTime = 0;
                Spawn();
            }
        }            

        if (health <= 0)
        {
            Explode();
        }

        if(health > 0)
        {
            Movement();
            Shoot();
        }
    }

    protected void Explode()
    {
        ypos = Random.Range(creationZone, creationZone + GameManager.Singleton().GetWorldHeight());
        currentState = eNPCState.Disabled;
    }

    protected void Spawn()
    {
        health = 1;
        xpos = Random.Range(GameManager.Singleton().GetWorldLeft(), GameManager.Singleton().GetWorldTop());
        ypos = GameManager.Singleton().GetWorldHeight() - GameManager.Singleton().GetWorldTop();
        zpos = GameManager.Singleton().GetWorldTop();
        transform.position = new Vector3(xpos, ypos, zpos);
        currentState = eNPCState.Active;
    }

    void Movement()
    {
        switch(currentEnemy)
        {
            case eEnemyType.Default:
                print("Default movement");
                break;
            case eEnemyType.Pigeon:
                print("Pigeon movement");
                break;
            case eEnemyType.Crow:
                print("Crow momento!");
                break;
        }

    }

    void OnTriggerEnter(Collider col)
    {
        //If it's a bullet we hit, deduct ONE POINT FROM GRYFINDO- Health. Yes. That.
        if(col.gameObject.tag == "Bullet")
        {
            Bullet bullet = col.GetComponent<Bullet>();

            // only respond to bullets fired by the player
            if (bullet.didPlayerFireMe)
            {
                health -= 1;
                //Polish needed, add some fancy GFX.
                
                // give player who shot it a score
                bullet.playerWhoFiredMe.AddScore(scoreValue);
            }
        }
    }

    protected void Shoot()
    {
        int wait = Random.Range(2, 8);
        deltaTime += Time.deltaTime;
        if(deltaTime >= wait)
        {
            //Fire the projectile
            //Fire(); <- this would be used to customise specific firing patterns. but for now use generic.

            switch(currentEnemy)
            {
                case eEnemyType.Default:
                    Fire(transform.position, transform.rotation);
                    SoundManager.EnemyFire(transform.position);
                    break;
                case eEnemyType.Pigeon:
                    Fire(transform.position, transform.rotation);
                    SoundManager.PidgeonSound(transform.position);
                    break;
                case eEnemyType.Crow:
                    Fire(transform.position, transform.rotation);
                    SoundManager.CrowSound(transform.position);
                    break;
            }

           // Fire(transform.position, transform.rotation);
            //Then reset deltaTime otherwise our bird friend will fire.
            deltaTime = 0;
        }
    }
}
