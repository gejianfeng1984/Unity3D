using UnityEngine;
using System.Collections;

public class CH07_03_GetKey : MonoBehaviour {

	private int keyFrame = 0;

	// Use this for initialization
	void Start () {
		keyFrame = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			Debug.Log("A key pressed.");
		}

		if (Input.GetKey(KeyCode.A)) {
			keyFrame++;
			Debug.Log("A key pressed for " + keyFrame + " frames.");
		}

		if (Input.GetKeyUp(KeyCode.A)) {
			keyFrame = 0;
			Debug.Log("A key released.");
		}
	
	}
}
