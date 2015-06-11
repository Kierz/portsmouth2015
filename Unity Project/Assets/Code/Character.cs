/*          File:       Character.cs
            Project:    RaType
            Author:     Kierz Phillips
            Purpose:    Game made for Portsmouh Game Jam 2015
 */

using UnityEngine;
using System.Collections;

public class Character : Entity
{
    // ---------------------------------
    // ------------- ENUMS -------------
    // ---------------------------------

    public enum eCharacterType
    {
        eCharacterTypePlayer,
        eCharacterTypeNPC,
    };

    // -------------------------------------
    // ------------- VARIABLES -------------
    // -------------------------------------

    public Bullet               bullet;
    public GameObject           firingAnimation;
    public GameObject           projectileAnimation;
    public eCharacterType       type;
    
    // ---------------------------------------------
    // ------------- CHAACTER FUNCTIONS ------------
    // ---------------------------------------------

    protected void Fire(Vector3 position, Quaternion direction)
    {
		Bullet fired = Instantiate( bullet, position, direction ) as Bullet;

		// tag the bullet
		fired.didPlayerFireMe = (type == eCharacterType.eCharacterTypePlayer);

        GameObject projecileAnim = Instantiate(projectileAnimation, position, Quaternion.EulerAngles(90.0f, 0.0f, 0.0f)) as GameObject;
        
        // attach projectile animation to bullet
        projecileAnim.transform.parent = fired.transform;

        if (fired.didPlayerFireMe)
            fired.playerWhoFiredMe = this as Player;        // god i hate C# typecasting

        // create firing animation
        GameObject firingAnim = Instantiate(firingAnimation, transform.position + (transform.forward * 0.35f), transform.rotation) as GameObject;
        firingAnim.transform.parent = this.transform;     // attach animation to this

        // rotate sprite
        firingAnim.transform.Rotate(90.0f, 0.0f, 0.0f);
        firingAnim.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        firingAnim.GetComponent<Animator>().speed = 5.0f;
    }
}
