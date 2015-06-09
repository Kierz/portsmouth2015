using UnityEngine;
using System.Collections;

public class RandomShake : MonoBehaviour
{
    private Vector3 newPos;
    float triggerDistance = 0.01f;
     
    void Start()
    {
        newPos = Random.insideUnitSphere;
    }

    // Update is called once per frame
    void Update()
    {        

        float distanceBetweenPoints = (transform.position - newPos).magnitude;

        if (distanceBetweenPoints <= triggerDistance)
        {
            newPos = Random.insideUnitSphere*0.5f;
        }

        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * 30);
        
    }
}
	
	

