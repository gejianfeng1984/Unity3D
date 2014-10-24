using UnityEngine;
using System.Collections;

public class CH07_01_KeyDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W)) {
			Debug.Log("You pressed key W.");
		}

		if (Input.GetKeyDown(KeyCode.S)) {
			Debug.Log("You pressed key S.");
		}

		if (Input.GetKeyDown(KeyCode.A)) {
			Debug.Log("You pressed key A.");
		}

		if (Input.GetKeyDown(KeyCode.D)) {
			Debug.Log("You pressed key D.");
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log("You pressed space key.");
		}
	}
}
