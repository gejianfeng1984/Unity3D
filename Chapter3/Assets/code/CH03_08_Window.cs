using UnityEngine;
using System.Collections;

public class CH03_08_Window : MonoBehaviour {

	private Rect window0 = new Rect(20, 20, 200, 200);
	private Rect window1 = new Rect(250, 20, 200, 200);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.Window(0, window0, firstWindow, "First Window");
		GUI.Window(1, window1, secondWindow, "Second Window");
	}

	void firstWindow(int windowId) {
		GUI.Box(new Rect(10, 50, 150, 50), "Window Id = " + windowId);
		if (GUI.Button(new Rect(10, 120, 150, 50), "Normal Button")) {
			Debug.Log("Window Id = " + windowId + " button has been clicked.");
		}
	}

	void secondWindow(int windowId) {
		GUI.Box(new Rect(10, 50, 150, 50), "Window Id = " + windowId);
		if (GUI.Button(new Rect(10, 120, 150, 50), "Normal Button")) {
			Debug.Log("Window Id = " + windowId + " button has been clicked.");
		}
	}
}
