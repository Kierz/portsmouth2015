using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
    private float lifeSpanRemaining;
    private float speed;
	public Entity whoFiredMe;

	void Start ()
    {
        lifeSpanRemaining = 1.0f;
		speed = 50.0f;
	}
	
	void Update () 
    {
        lifeSpanRemaining -= Time.deltaTime;

        if (lifeSpanRemaining <= 0.0f)
        {
            DestroyObject(gameObject);
        }

        else
        {
			transform.position += transform.forward * Time.deltaTime * speed;
        }
	}
}
