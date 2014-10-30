using UnityEngine;
using System.Collections;

public class CH08_06_CaptureScreenShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUILayout.Label("Scene Name: " + Application.loadedLevelName);
		if (GUILayout.Button("Capture Screen")) {
			Application.CaptureScreenshot("name.png");
		}
	}
}
