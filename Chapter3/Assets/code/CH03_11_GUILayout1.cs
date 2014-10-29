using UnityEngine;
using System.Collections;

public class CH03_11_GUILayout1 : MonoBehaviour {

	private string addStr = "Add Test String ";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		if (GUI.Button(new Rect(50, 50, 100, 30), addStr)) {
			addStr += addStr;
		}

		if (GUILayout.Button(addStr)) {
			addStr += addStr;
		}
	}
}
