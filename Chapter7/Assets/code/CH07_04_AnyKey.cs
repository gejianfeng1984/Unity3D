using UnityEngine;
using System.Collections;

public class CH07_04_AnyKey : MonoBehaviour {

	int keyFrame = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			keyFrame = 0;
			Debug.Log("Any key is pressed.");
		}

		if (Input.anyKey) {
			keyFrame++;
			Debug.Log("Any key is pressed for " + keyFrame + " frames.");
		}
	}
}
