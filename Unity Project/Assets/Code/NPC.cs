//NPC.cs
//10.06.15
//Last edited by James Davidson & Matthew Moore

using UnityEngine;
using System.Collections;

public class NPC : Character
{
    public int health, speed;
    private float xpos, zpos = 0;
    protected float deltaTime = 0;

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

    private eNPCState currentState = eNPCState.Disabled;
    private eEnemyType currentEnemy = eEnemyType.Default;

     void Start()
    {

    }

    protected void Update()
    {
        if (currentState == eNPCState.Disabled)
            Spawn();

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
        print("EXPLOSION OCCURED!");
        currentState = eNPCState.Disabled;
    }

    protected void Spawn()
    {
        health = 1;
        xpos = Random.Range(GameManager.Singleton().GetWorldLeft(), GameManager.Singleton().GetWorldTop());
        zpos = GameManager.Singleton().GetWorldTop();
        transform.position = new Vector3(xpos, 0.0f, zpos);
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
            health -= 1;
            //Polish needed, add some fancy GFX.
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
                    break;
                case eEnemyType.Pigeon:
                    Fire(transform.position, transform.rotation);
                    break;
                case eEnemyType.Crow:
                    Fire(transform.position, transform.rotation);
                    break;
            }

           // Fire(transform.position, transform.rotation);
            //Then reset deltaTime otherwise our bird friend will fire.
            deltaTime = 0;
        }

    }

    //Unused method for now, consider in polishing time.
    //protected void Fire()
    //{

    //}
}
