using UnityEngine;
using System.Collections;

public class CH07_02_KeyUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Key Down Event
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

		// Key Up Event
		if (Input.GetKeyUp(KeyCode.W)) {
			Debug.Log("You released key W.");
		}

		if (Input.GetKeyUp(KeyCode.S)) {
			Debug.Log("You released key S.");
		}

		if (Input.GetKeyUp(KeyCode.A)) {
			Debug.Log("You released key A.");
		}

		if (Input.GetKeyUp(KeyCode.D)) {
			Debug.Log("You released key D.");
		}

		if (Input.GetKeyUp(KeyCode.Space)) {
			Debug.Log("You released space key.");
		}
	}
}
