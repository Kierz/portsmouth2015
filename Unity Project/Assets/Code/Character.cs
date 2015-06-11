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
    public eCharacterType       type;

    // ---------------------------------------------
    // ------------- CHAACTER FUNCTIONS ------------
    // ---------------------------------------------

    protected void Fire(Vector3 position, Quaternion direction)
    {
		Bullet fired = Instantiate( bullet, position, direction ) as Bullet;

		// tag the bullet
		fired.didPlayerFireMe = (type == eCharacterType.eCharacterTypePlayer);

        if (fired.didPlayerFireMe)
            fired.playerWhoFiredMe = this as Player;        // god i hate C# typecasting
    }
}
