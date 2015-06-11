using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	//Detect when mouse clicks on a button
	void OnMouseDown()
	{
		if (name == "Start Game") {
			Application.LoadLevel("Main");
		}
		
		if (name == "Exit Game") {
			Application.Quit();
		}
	}
}
