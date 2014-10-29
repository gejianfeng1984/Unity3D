using UnityEngine;
using System.Collections;

public class CH03_14_Space : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUILayout.BeginArea(new Rect(0, 0, 200, 60));

		GUILayout.BeginHorizontal();

		GUILayout.BeginVertical();
		GUILayout.Box("Test1");
		GUILayout.Space(10);
		GUILayout.Box("Test2");
		GUILayout.EndVertical();

		GUILayout.Space(20);

		GUILayout.BeginVertical();
		GUILayout.Box("Test3");
		GUILayout.Space(10);
		GUILayout.Box("Test4");
		GUILayout.EndVertical();

		GUILayout.EndHorizontal();

		GUILayout.EndArea();
	}
}
