using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{

    private float lifeSpanRemaining;
    private float speed = 0.75f;

	// Use this for initialization
	void Start ()
    {
        lifeSpanRemaining = 1.0f;
	}
	
	// Update is called once per frame
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
