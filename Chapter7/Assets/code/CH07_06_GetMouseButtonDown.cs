using UnityEngine;
using System.Collections;

public class CH07_06_GetMouseButtonDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("Left Mouse Button Click Position: " + Input.mousePosition);
		}

		if (Input.GetMouseButtonDown(1)) {
			Debug.Log("Right Mouse Button Click Position: " + Input.mousePosition);
		}

		if (Input.GetMouseButtonDown(2)) {
			Debug.Log("Middle Mouse Button Click Position: " + Input.mousePosition);
		}
	}
}
