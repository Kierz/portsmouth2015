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

    private eEnemyType              currentEnemy;
    protected float                 creationZone;       // ypos of the creation zone

    public float                    fireDelay;
    private float                   delayBeforeFiring;

    
    // ------------------------------------------
    // ------------- NPC FUNCTIONS  -------------
    // ------------------------------------------

    void Start()
    {
        gameObject.tag =   "Enemy";
        speed =            0;
        currentEnemy =     eEnemyType.Default;
        creationZone =     GameManager.Singleton().GetCreationZone();
        delayBeforeFiring = 0;

        if (fireDelay == 0)
            fireDelay = 1.0f;           // if fire delay has not been set, default to 1 second
    }

    protected void Update()
    {
        if (npcActive)
        {
            if (health <= 0)
            {
                GameManager.Singleton().DeactivateEntity(this);
            }

            if (health > 0)
            {
                Movement();
                Shoot();
            }
        }
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
        delayBeforeFiring -= Time.deltaTime;

        if (delayBeforeFiring <= 0.0f)
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

            // reset timer
            delayBeforeFiring = fireDelay;
        }
    }
}