using UnityEngine;
using System.Collections;

public class CH03_06_ScrollView : MonoBehaviour {

	private Vector2 scrollPosition;

	// Use this for initialization
	void Start () {
		scrollPosition[0] = 50;
		scrollPosition[1] = 50;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		scrollPosition = GUI.BeginScrollView(new Rect(0, 0, 200, 200), scrollPosition, new Rect(0, 0, Screen.width, 300), true, true);
		GUI.Label(new Rect(100, 40, Screen.width, 30), "Test Scroll View, Test Scroll View, Test Scroll View, Test Scroll View, Test Scroll View, Test Scroll View");
		GUI.EndScrollView();
	}
}
