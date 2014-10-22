using UnityEngine;
using System.Collections;

public class CH03_04_ToolBar : MonoBehaviour {

	private int select;
	private string[] barResource;
	private bool selectToggle0;
	private bool selectToggle1;

	// Use this for initialization
	void Start () {
		select = 0;
		barResource = new string[] {"Tool Bar 1", "Tool Bar 2", "Tool Bar 3" , "Tool Bar 4"};
		selectToggle0 = false;
		selectToggle1 = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		int oldSelect = select;

		select = GUI.Toolbar(new Rect(10, 10, barResource.Length * 150, 30), select, barResource);
		if (oldSelect != select) {
			selectToggle0 = false;
			selectToggle1 = false;
		}

		switch (select) {
		case 0:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "Tool Bar 1 - Selection 1");
			selectToggle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selectToggle1, "Tool Bar 1 - Selection 2");
			break;
		case 1:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "Tool Bar 2 - Selection 1");
			selectToggle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selectToggle1, "Tool Bar 2 - Selection 2");
			break;
		case 2:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "Tool Bar 3 - Selection 1");
			selectToggle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selectToggle1, "Tool Bar 3 - Selection 2");
			break;
		case 3:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "Tool Bar 4 - Selection 1");
			selectToggle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selectToggle1, "Tool Bar 4 - Selection 2");
			break;
		}
	}
}
