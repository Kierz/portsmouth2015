using UnityEngine;
using System.Collections;
<<<<<<< HEAD:Unity Project/Assets/Bullet.cs

public class Bullet : MonoBehaviour 
{
=======
>>>>>>> 55f88e813695b7f67b6a5c7d1157c155971a242a:Unity Project/Assets/Code/Bullet.cs

public class Bullet : MonoBehaviour 
{
    private float lifeSpanRemaining;
<<<<<<< HEAD:Unity Project/Assets/Bullet.cs
    private float speed = 0.75f;

	// Use this for initialization
	void Start ()
    {
        lifeSpanRemaining = 1.0f;
	}
	
	// Update is called once per frame
=======
    private float speed = 0.5f;

	void Start ()
    {
        lifeSpanRemaining = 5.0f;
	}
	
>>>>>>> 55f88e813695b7f67b6a5c7d1157c155971a242a:Unity Project/Assets/Code/Bullet.cs
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
