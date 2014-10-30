using UnityEngine;
using System.Collections;
using UnityEditor;

public class CH08_10_CreateFolder : MonoBehaviour {

	int addId = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		if (GUILayout.Button("Create Folder")) {
			string folderName = "createFolder" + addId;
			AssetDatabase.CreateFolder("Assets/resource", folderName);
			Material mat = new Material(Shader.Find("Transparent/Diffuse"));
			AssetDatabase.CreateAsset(mat, "Assets/resource/" + folderName + "/mat.mat");
			addId++;
		}
	}
}
