using UnityEngine;
using System.Collections;

public class CH08_05_SwitchScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUILayout.Label("Scene Name: " + Application.loadedLevelName);
		if (GUILayout.Button("Click to previous scene!")) {
			Application.LoadLevel("CH08_03_ReadFile");
		}
	}
}
