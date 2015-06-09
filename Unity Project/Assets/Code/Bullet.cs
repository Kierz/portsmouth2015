using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
    private float lifeSpanRemaining;
    private float speed = 0.5f;

	void Start ()
    {
        lifeSpanRemaining = 5.0f;
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
             transform.Translate(transform.forward * speed);
        }
	}
}
