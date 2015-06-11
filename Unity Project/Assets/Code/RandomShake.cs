/*          File:       RandomShake.cs
            Project:    RaType
            Authors:    Phil Alassad
                        Kierz Phillips
            Purpose:    Game made for Portsmouh Game Jam 2015
 */

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
		originalPos = transform.localPosition;
		CreateNewPosition();        
    }

    void Update()
    {
		float distanceBetweenPoints = ( transform.localPosition - newPos ).magnitude;

        if (distanceBetweenPoints <= triggerDistance)
        {
			CreateNewPosition();
        }

		transform.localPosition = Vector3.MoveTowards( transform.localPosition, newPos, Time.deltaTime );
    }

	private void CreateNewPosition()
	{
		Vector3 randomOffset = Random.insideUnitSphere * 0.32f;

		randomOffset.y = 0.0f;

		newPos = originalPos + randomOffset;
	}
}
	
	

