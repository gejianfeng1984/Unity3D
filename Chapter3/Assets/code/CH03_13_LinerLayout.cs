using UnityEngine;
using System.Collections;

public class CH03_13_LinerLayout : MonoBehaviour {

	public Texture2D texture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUILayout.BeginHorizontal();
		GUILayout.Box("Start horizontal layout.");
		GUILayout.Button("Button");
		GUILayout.Label("Label");
		GUILayout.TextField("Text Field");
		GUILayout.Box(texture);
		GUILayout.EndHorizontal();
		
		GUILayout.BeginVertical();
		GUILayout.Box("Start vertical layout.");
		GUILayout.Button("Button");
		GUILayout.Label("Label");
		GUILayout.TextField("Text Field");
		GUILayout.Box(texture);
		GUILayout.EndVertical();
	}
}
