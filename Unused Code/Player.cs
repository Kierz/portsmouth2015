/*
	File:			Player.cs
	Author:			Krz
	Project:		Ship Game
	Soundtrack:		Fnoob Techno Radio
	Description:	All general Player related stuff here
*/

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    // -------------------------------------
    // ------------- VARIABLES -------------
    // -------------------------------------

    protected float health=0f;                                      // value of health
    protected float fireTimer=0f;                                   // time since last fired

    private float hurtTimer=0f;                                     // stop me getting hit more than once in half a second
    private static float HURT_DURATION =                            0.5f;

    protected float fireDelay=0f;
    protected static float DEFAULT_DAMAGE = 10f;                    // default damage of each shot
    protected float aimCorrectionFactor;                            // factor to scale x aim by to aim correctly (same as aspect ratio)
    protected float screenWidthReceip;                              // screen width receiprocal
    protected float screenHeightReceip;                             // screen width receiprocal
    public GameObject target;                                       // location of our target

    // ---------------------------------------------
    // ------------- STANDARD FUNCTIONS ------------
    // ---------------------------------------------

	void Start () {
        StartChar();

        // calculate receips
        screenHeightReceip = 1f / Screen.height;
        screenWidthReceip = 1f / Screen.width;

        // setup aim correction factor
        aimCorrectionFactor = (float)Screen.width / (float)Screen.height;
	}

    // override me
    protected virtual void StartChar() { }

	// Update is called once per frame
    void Update() {
        if (hurtTimer >= 0f) { hurtTimer -= Time.deltaTime; }
        fireTimer += Time.deltaTime;
        UpdatePlayer();
	}

    // these should be over-ridden
    protected virtual void UpdatePlayer() { }
    public virtual void Respawn() { }

    // ---------------------------------------------
    // ------------- STANDARD FUNCTIONS ------------
    // ---------------------------------------------

    public void TakeDamage()
    {
        TakeDamage(DEFAULT_DAMAGE, false);
    }

    public void TakeDamage(float damage) {
        TakeDamage(damage, true);
    }

    public void TakeDamage(float damage, bool forced) {
        if (hurtTimer <= 0f || forced) {
            ModifyHealth(-damage);
            hurtTimer = HURT_DURATION;
        }
    }

    protected void ModifyHealth(float received) {
        health += received;

        if (health < 0f) {
            GameManager.Singleton().GameOver();
        }

        health = Mathf.Clamp(health, 0f, 100f);
    }

    protected void Fire(Vector3 targetLocation)
    {
        // ready, aim....
        LookAt(targetLocation);

        // FIRE!
        Fire();
    }

    protected void Fire() {
        if (fireTimer > fireDelay)
        {
            // reset timer
            fireTimer = 0f;

            // create bullet at our position, facing our direction
            Instantiate(GameManager.Singleton().bulletObj, transform.position, transform.rotation);     // FIRE!
        }
    }



    protected Vector3 ScreenPositionToDirection(Vector3 targetPosition) {
        Vector3 returnVector = Vector3.zero;

        returnVector.x = (targetPosition.x * screenWidthReceip) - 0.5f;
        returnVector.y = 0f;                                            // capped at same level as all objects
        returnVector.z = (targetPosition.y * screenHeightReceip) - 0.5f;

        // scale x by aim correction factor
        returnVector.x *= aimCorrectionFactor;

        return returnVector;
    }

    protected void LookAt(Vector3 targetPosition) {
        if (!target) { return; }

        // change target location
        target.transform.position = ScreenPositionToDirection(targetPosition);

        // look at new target and fire
        transform.LookAt(target.transform);
    }
}
