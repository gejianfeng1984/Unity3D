using UnityEngine;
using System.Collections;

public class CH07_08_GetMouseButton : MonoBehaviour {

	private int iMouseFrame = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			iMouseFrame++;
			Debug.Log("Hold Left Mouse Button for " + iMouseFrame + " frames.");
		}

		if (Input.GetMouseButton(1)) {
			iMouseFrame++;
			Debug.Log("Hold Right Mouse Button for " + iMouseFrame + " frames.");
		}

		if (Input.GetMouseButton(2)) {
			iMouseFrame++;
			Debug.Log("Hold Middle Mouse Button for " + iMouseFrame + " frames.");
		}

		if (Input.GetMouseButtonUp(0)) {
			iMouseFrame = 0;
		}

		if (Input.GetMouseButtonUp(1)) {
			iMouseFrame = 0;
		}

		if (Input.GetMouseButtonUp(2)) {
			iMouseFrame = 0;
		}
	}
}
