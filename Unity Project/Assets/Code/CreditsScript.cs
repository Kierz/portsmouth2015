using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour
{
    public GameObject credits;
    public GameObject stopPoint;
    private float scrollingSpeed;

    void Start()
    {
        scrollingSpeed = 2.0f;
    }

	void Update ()
    {
        credits.transform.position -= Vector3.up * Time.deltaTime * scrollingSpeed;

        if (credits.transform.position.y <= stopPoint.transform.position.y)
        {
            Application.LoadLevel("MainMenu");
        }
	}
}
