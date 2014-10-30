using UnityEngine;
using System.Collections;
using UnityEditor;

public class CH08_08_LoadAssert : MonoBehaviour {

	private Texture2D texture;

	// Use this for initialization
	void Start () {
		texture = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/resource/icon_vip2.png", typeof(Texture2D));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		if (texture != null) {
			GUI.DrawTexture(new Rect(0, 0, texture.width, texture.height), texture);
		}
	}
}
