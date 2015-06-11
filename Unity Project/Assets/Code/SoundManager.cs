/*          File:       SoundManager.cs
            Project:    RaType
            Author:     Kierz Phillips
            Purpose:    Game made for Portsmouh Game Jam 2015
 */


using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour 
{
	// -------------------------------------
	// ------------- VARIABLES -------------
	// -------------------------------------

	// prefabs
	public List<AudioClip> explosions;
    public AudioClip playerFire;
    public AudioClip playerDeath;
    public AudioClip enemyFire;
	public AudioClip crowSound;
	public AudioClip pidgeonSound;
	public AudioClip leaves;

	// -------------------------------------
	// ------------- SINGLETON -------------
	// -------------------------------------

	private static SoundManager sm;
	public static SoundManager Singleton()
    {
		if ( !sm )
        {
			sm = FindObjectOfType<SoundManager>();
		}

		return sm;
	}

	// ------------------------------------------
	// ------------- SOUND FUNCTIONS ------------
	// ------------------------------------------

	public static void Explosion(Vector3 location) 
    {
		int random = Random.Range( 0, Singleton().explosions.Count );
		AudioSource.PlayClipAtPoint( Singleton().explosions[random], location, 0.1f );
	}

    public static void PlayerFire(Vector3 location)
    {
        AudioSource.PlayClipAtPoint(Singleton().playerFire, location, 1.0f);
    }

    public static void EnemyFire(Vector3 location)
    {
        AudioSource.PlayClipAtPoint(Singleton().enemyFire, location, 1.0f);
    }

    public static void PlayerDeath(Vector3 location)
    {
        AudioSource.PlayClipAtPoint(Singleton().playerDeath, location, 1.0f);
    }

    public static void CrowSound(Vector3 location)
    {
        AudioSource.PlayClipAtPoint(Singleton().crowSound, location, 1.0f);
    }

    public static void PidgeonSound(Vector3 location)
    {
        AudioSource.PlayClipAtPoint(Singleton().pidgeonSound, location, 1.0f);
    }

    public static void LeavesSound(Vector3 location)
    {
        AudioSource.PlayClipAtPoint(Singleton().leaves, location, 1.0f);
    }
}
