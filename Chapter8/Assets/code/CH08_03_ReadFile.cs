using UnityEngine;
using System.Collections;
using System.IO;

public class CH08_03_ReadFile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ArrayList info = LoadFile(Application.dataPath, "FileName");

		foreach(string str in info) {
			Debug.Log(str);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	ArrayList LoadFile(string path, string name) {
		StreamReader sr = null;

		try {
			sr = File.OpenText(path + "//" + name);
		} catch (System.Exception e) {
			return null;
		}

		string line;
		ArrayList arrList = new ArrayList();

		while((line = sr.ReadLine ()) != null) {
			arrList.Add(line);
		}

		sr.Close();
		sr.Dispose();
		return arrList;
	}
}
