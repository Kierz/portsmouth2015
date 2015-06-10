﻿using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour
{
    public GameObject credits;
    public GameObject stopPoint;
    private float scrollingSpeed;

    void Start()
    {
        scrollingSpeed = 1.0f;
    }

	void Update ()
    {
        // return to main menu on escape press
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("MainMenu");
        
        credits.transform.position += Vector3.up * Time.deltaTime * scrollingSpeed;

        if (credits.transform.position.y >= stopPoint.transform.position.y)
        {
            Application.LoadLevel("MainMenu");
        }
	}
}
