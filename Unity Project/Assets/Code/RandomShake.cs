using UnityEngine;
using System.Collections;

public class RandomShake : MonoBehaviour
{
	private Vector3 originalPos;
    private Vector3 newPos;
    private float triggerDistance;

     
    void Start()
    {
		triggerDistance = 0.25f;
		originalPos = transform.position;
		CreateNewPosition();        
    }

    void Update()
    {   
        float distanceBetweenPoints = (transform.position - newPos).magnitude;

        if (distanceBetweenPoints <= triggerDistance)
        {
			CreateNewPosition();
        }
		
		transform.position = Vector3.MoveTowards( transform.position, newPos, Time.deltaTime * 20.0f );
    }

	private void CreateNewPosition()
	{
		print( "newposition" );
		Vector3 randomOffset = Random.insideUnitSphere;

		randomOffset.y = 0.0f;

		newPos = originalPos + randomOffset;
	}
}
	
	

