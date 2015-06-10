using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour
{
    public BoxCollider2D start;
    public BoxCollider2D credits;
    public BoxCollider2D quit;

	void Update ()
    {
        if (Input.GetButtonDown("Start_P1") || Input.GetButtonDown("Start_P2") || Input.GetButtonDown("Start_P3") || Input.GetButtonDown("Start_P4"))
            Application.LoadLevel("Main");

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0.0f;
            
            if (start.bounds.Contains(mousePos))
                Application.LoadLevel("Main");

            if (credits.bounds.Contains(mousePos))
                Application.LoadLevel("Credits");

            if (quit.bounds.Contains(mousePos))
                Application.Quit();
        }
	}
}
