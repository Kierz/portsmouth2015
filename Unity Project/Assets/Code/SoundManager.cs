using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour {
	// -------------------------------------
	// ------------- VARIABLES -------------
	// -------------------------------------

	// prefabs
	public List<AudioClip> explosions;
	public AudioClip playerFire;
	public AudioClip enemyFire;
	public AudioClip gameover;
	public AudioClip hit;
	public AudioClip go;
	public AudioClip countdown;
	public AudioClip bonus;
	public AudioClip kamiSpawn;

	// -------------------------------------
	// ------------- SINGLETON -------------
	// -------------------------------------

	private static SoundManager sm;
	public static SoundManager Singleton() {
		if ( !sm ) {
			sm = FindObjectOfType<SoundManager>();
		}

		return sm;
	}

	// ------------------------------------------
	// ------------- SOUND FUNCTIONS ------------
	// ------------------------------------------

	public static void Explosion(Vector3 location) {
		int random = Random.Range( 0, Singleton().explosions.Count );
		AudioSource.PlayClipAtPoint( Singleton().explosions[random], location, 0.1f );
	}

	public static void Fire( Vector3 location, bool player ) {
		if ( player ) {
			AudioSource.PlayClipAtPoint( Singleton().playerFire, location, 0.5f );
		}
		else {
			AudioSource.PlayClipAtPoint( Singleton().enemyFire, location, 1.0f );
		}
	}

	public static void Gameover( Vector3 location ) {
		AudioSource.PlayClipAtPoint( Singleton().gameover, location, 1.0f);
	}

	public static void Hit( Vector3 location ) {
		AudioSource.PlayClipAtPoint( Singleton().hit, location, 1.0f );
	}

	public static void Go() {
		AudioSource.PlayClipAtPoint( Singleton().go, Singleton().transform.position, 1.0f );
	}

	public static void Countdown() {
		AudioSource.PlayClipAtPoint( Singleton().countdown, Singleton().transform.position, 1.0f );
	}

	public static void KamiLaunched() {
		AudioSource.PlayClipAtPoint( Singleton().kamiSpawn, Singleton().transform.position, 1.0f );
	}

	public static void BonusTriggered() {
		AudioSource.PlayClipAtPoint( Singleton().bonus, Singleton().transform.position, 1.0f );
	}
}
