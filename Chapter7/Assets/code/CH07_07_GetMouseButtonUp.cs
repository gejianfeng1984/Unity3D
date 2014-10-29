using UnityEngine;
using System.Collections;

public class CH07_07_GetMouseButtonUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0)) {
			Debug.Log("Release Left Mouse Button Position: " + Input.mousePosition);
		}

		if (Input.GetMouseButtonUp(1)) {
			Debug.Log("Release Right Mouse Button Position: " + Input.mousePosition);
		}

		if (Input.GetMouseButtonUp(2)) {
			Debug.Log("Release Middle Mouse Button Position: " + Input.mousePosition);
		}
	}
}
