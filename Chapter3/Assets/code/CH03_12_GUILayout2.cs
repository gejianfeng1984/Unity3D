using UnityEngine;
using System.Collections;

public class CH03_12_GUILayout2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUILayout.Button("Width: 300 | Height: 30", GUILayout.Width(300), GUILayout.Height(30));
		GUILayout.Button("Min Width: 100 | Min Height: 20", GUILayout.MinWidth(100), GUILayout.MinHeight(20));
		GUILayout.Button("Max Width: 400 | Max Height: 40", GUILayout.MaxWidth(400), GUILayout.MaxHeight(40));
		GUILayout.Button("ExpandWidth: false", GUILayout.ExpandWidth(false));
		GUILayout.Button("ExpandWidth: true", GUILayout.ExpandWidth(true));
	}
}
