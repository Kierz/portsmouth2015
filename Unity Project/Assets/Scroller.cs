using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour
{
   // public float scrollSpeed;
    //public float tileSizeZ;

    //private Vector3 startPosition;

    void Start ()
    {
       // startPosition = transform.position;
    }

    void Update ()
    {
        transform.Translate(0.0f, 0.0f, -Time.deltaTime);
        if (transform.position.z <= -15.0f)
        {
            transform.position = new Vector3(0.0f, 0.0f, 30.0f);
        }
        //float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        //transform.position = startPosition + Vector3.forward * newPosition;
    }

}


