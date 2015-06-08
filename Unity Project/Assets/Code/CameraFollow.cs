using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
    private playerController player;

    void Start()
    {
        player = FindObjectOfType<playerController>();
    }

    void Update ()
    {
        transform.position = player.transform.position + new Vector3(0.0f, 10.0f, -2.0f);
	}
}
