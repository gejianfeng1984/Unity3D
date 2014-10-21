using UnityEngine;
using System.Collections;

public class CH03_01_Label : MonoBehaviour {

	public string str;
	public Texture imageTexture;

	private int imageWidth;
	private int imageHeight;
	private int screenWidth;
	private int screenHeight;

	// Use this for initialization
	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		imageWidth = imageTexture.width;
		imageHeight = imageTexture.height;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.Label(new Rect(100, 10, 150, 30), str);
		GUI.Label(new Rect(100, 40, 150, 30), "Screen Width: " + screenWidth);
		GUI.Label(new Rect(100, 70, 150, 30), "Screen Height: " + screenHeight);
		GUI.Label(new Rect(100, 100, imageWidth, imageHeight), imageTexture);
	}
}
