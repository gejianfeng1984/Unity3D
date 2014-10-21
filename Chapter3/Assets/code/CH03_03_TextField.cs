using UnityEngine;
using System.Collections;

public class CH03_03_TextField : MonoBehaviour {

	private string editUsername;
	private string editPassword;

	private string editShow;

	// Use this for initialization
	void Start () {
		editUsername = "[Username]";
		editPassword = "[Password]";
		editShow = "Please enter your username and password.";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.Label(new Rect(10, 10, Screen.width, 30), editShow);

		if (GUI.Button(new Rect(10, 120, 100, 50), "Login")) {
			editShow = "Username: " + editUsername + " | Password: " + editPassword;
		}

		GUI.Label(new Rect(10, 40, 80, 30), "Username:");
		GUI.Label(new Rect(10, 80, 80, 30), "Password:");

		editUsername = GUI.TextField(new Rect(85, 40, 200, 30), editUsername, 15);
		editPassword = GUI.PasswordField(new Rect(85, 80, 200, 30), editPassword, "*"[0], 15);
	}
}
