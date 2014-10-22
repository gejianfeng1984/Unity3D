using UnityEngine;
using System.Collections;

public class CH03_07_GroupView : MonoBehaviour {

	public Texture2D viewTexture0;
	public Texture2D viewTexture1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.BeginGroup(new Rect(10, 50, 200, 400));
		GUI.DrawTexture(new Rect(10, 20, viewTexture0.width, viewTexture0.height), viewTexture0);
		GUI.Label(new Rect(10, 150, 100, 40), "Group View 1");
		GUI.Button(new Rect(10, 190, 100, 40), "Button");
		GUI.EndGroup();

		GUI.BeginGroup(new Rect(300, 0, 500, 400));
		GUI.DrawTexture(new Rect(10, 20, viewTexture1.width, viewTexture1.height), viewTexture1);
		GUI.Label(new Rect(10, 150, 100, 40), "Group View 2");
		GUI.Button(new Rect(10, 190, 100, 40), "Button");
		GUI.EndGroup();
	}
}
