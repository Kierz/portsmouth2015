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
        transform.position = player.transform.position;
	}
}
