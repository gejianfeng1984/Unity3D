using UnityEngine;
using System.Collections;

public class CH08_01_PlayerPrefs : MonoBehaviour {

	private string username = "";
	private string usernumber = "";
	private string userage = "";
	private string userheight = "";

	private bool showInfo = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUILayout.BeginHorizontal("box", GUILayout.Width(200));
		GUILayout.Label("Username: ");
		username = GUILayout.TextField(username, 10);
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal("box");
		GUILayout.Label("Number: ");
		usernumber = GUILayout.TextField(usernumber, 11);
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal("box");
		GUILayout.Label("Age: ");
		userage = GUILayout.TextField(userage, 2);
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal("box");
		GUILayout.Label("Height: ");
		userheight = GUILayout.TextField(userheight, 5);
		GUILayout.EndHorizontal();

		if (GUILayout.Button("Submit")) {
			showInfo = true;
			PlayerPrefs.SetString("username", username);
			PlayerPrefs.SetString("usernumber", usernumber);
			PlayerPrefs.SetInt("userage", int.Parse(userage));
			PlayerPrefs.SetFloat("userheight", float.Parse(userheight));
		}

		if (GUILayout.Button("Clear")) {
			showInfo = false;
			PlayerPrefs.DeleteAll();
		}

		if (showInfo == true) {
			GUILayout.Label("Username: " + PlayerPrefs.GetString("username"));
			GUILayout.Label("Number: " + PlayerPrefs.GetString("usernumber"));
			GUILayout.Label("Age: " + PlayerPrefs.GetInt("userage"));
			GUILayout.Label("Height: " + PlayerPrefs.GetFloat("userheight"));
		}
	}
}
