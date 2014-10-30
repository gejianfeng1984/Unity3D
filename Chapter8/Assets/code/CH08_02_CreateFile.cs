using UnityEngine;
using System.Collections;
using System.IO;

public class CH08_02_CreateFile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CreateFile(Application.dataPath, "FileName", "TestInfo0");
		CreateFile(Application.dataPath, "FileName", "TestInfo1");
		CreateFile(Application.dataPath, "FileName", "TestInfo2");
	}

	// Update is called once per frame
	void Update () {
	
	}

	void CreateFile(string path, string name, string info) {
		StreamWriter sw;
		FileInfo t = new FileInfo(path + "//" + name);
		if (!t.Exists) {
			sw = t.CreateText();
		}
		else {
			sw = t.AppendText();
		}

		sw.WriteLine(info);
		sw.Close();
		sw.Dispose();
	}
}
