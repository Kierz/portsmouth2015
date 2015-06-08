using UnityEngine;
using System.Collections;

public class randomShake : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        transform.localPosition = Random.insideUnitSphere * 0.1f/*shakeAmount*/;

    }
}
	
	

