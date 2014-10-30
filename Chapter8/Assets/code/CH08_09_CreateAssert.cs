using UnityEngine;
using System.Collections;
using UnityEditor;

public class CH08_09_CreateAssert : MonoBehaviour {

	private Texture2D texture = null;

	// Use this for initialization
	void Start () {
		Material mat = new Material(Shader.Find("Transparent/Diffuse"));
		texture = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/resource/icon_vip2.png", typeof(Texture2D));
		mat.mainTexture = texture;
		AssetDatabase.CreateAsset(mat, "Assets/resource/mat.mat");
		GameObject objCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		objCube.GetComponent<Renderer>().material = mat;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
