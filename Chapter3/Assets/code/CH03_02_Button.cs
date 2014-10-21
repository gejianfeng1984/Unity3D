using UnityEngine;
using System.Collections;

public class CH03_02_Button : MonoBehaviour {

	public Texture2D buttonTexture;

	private int frameTime;
	private string str;

	// Use this for initialization
	void Start () {
		str = "Click Button";
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		GUI.Label(new Rect(10, 10, Screen.width, 30), str);
		
		if (GUI.Button(new Rect(10, 50, buttonTexture.width, buttonTexture.height), buttonTexture)) {
			str = "You click image button.";
		}
		
		GUI.color = Color.green;
		GUI.backgroundColor = Color.red;
		
		if (GUI.Button(new Rect(10, 200, 120, 30), "Text Button")) {
			str = "You click text button.";
		}
		
		GUI.color = Color.yellow;
		GUI.backgroundColor = Color.black;
		
		if (GUI.RepeatButton(new Rect(10, 250, 150, 30), "Button In Pressed")) {
			str = "Button is pressed for " + frameTime + " frames.";
			frameTime++;
		}
	}
}
