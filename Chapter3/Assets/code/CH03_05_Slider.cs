using UnityEngine;
using System.Collections;

public class CH03_05_Slider : MonoBehaviour {

	private float verticalValue = 0.0f;
	private float horizontalValue = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		verticalValue = GUI.VerticalSlider(new Rect(25, 25, 30, 100), verticalValue, 100, 0);
		horizontalValue = GUI.HorizontalSlider(new Rect(50, 25, 100, 30), horizontalValue, 0, 100);

		GUI.Label(new Rect(10, 150, Screen.width, 30), "Vertical Slider Value: " + verticalValue);
		GUI.Label(new Rect(10, 180, Screen.width, 30), "Horizontal Slider Value: " + horizontalValue);
	}
}
