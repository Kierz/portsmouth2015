/*          File:       Bullet.cs
            Project:    RaType
            Authors:    Phil Alassad
                        Kierz Phillips
            Purpose:    Game made for Portsmouh Game Jam 2015
 */

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    private float lifeSpanRemaining;
    private float speed;
    public Player playerWhoFiredMe;
    public bool didPlayerFireMe;



    float amplitudeX = 10.0f;
    float amplitudeZ = 5.0f;
    float omegaX ;
    float omegaZ ;
    float index;





    void Start()
    {
        lifeSpanRemaining = 1.0f;
        speed = 50.0f;
    }

    void Update()
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
        
	

