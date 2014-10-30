using UnityEngine;
using System.Collections;

public class CH08_07_OpenURL : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUILayout.Label("Scene Name: " + Application.loadedLevelName);
		if (GUILayout.Button("Open URL")) {
			Application.OpenURL("http://www.baidu.com");
		}
	}
}
