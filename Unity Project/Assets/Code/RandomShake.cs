using UnityEngine;
using System.Collections;

public class RandomShake : MonoBehaviour
{
    private Vector3 newPos;
    float triggerDistance = 0.01f;
     

   /* private static Vector3 Vector3(int p1, int p2, int p3)
    {
        throw new System.NotImplementedException();
    }*/
    // Use this for initialization
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
            newPos = Random.insideUnitSphere;
        }

       // transform.localPosition = Random.insideUnitSphere * 0.1f/*shakeAmount*/;

    }
}
	
	

