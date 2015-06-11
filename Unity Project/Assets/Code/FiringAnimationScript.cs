using UnityEngine;
using System.Collections;

public class FiringAnimationScript : MonoBehaviour 
{
    private float lifespan;

	void Start () 
    {
        lifespan = 0.14f;
	}
	
	void Update () 
    {
        if ((lifespan -= Time.deltaTime) <= 0.0f)
        {
            DestroyObject(gameObject);
        }
	}
}
