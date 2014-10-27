using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CH07_05_CombineKey : MonoBehaviour {

	public Texture imageUp;
	public Texture imageDown;
	public Texture imageLeft;
	public Texture imageRight;
	public Texture imageSuccess;

	public const int KEY_UP = 0;
	public const int KEY_DOWN = 1;
	public const int KEY_LEFT = 2;
	public const int KEY_RIGHT = 3;
	public const int KEY_FIRT = 4;

	public const int FRAME_COUNT = 100;
	public const int SAMPLE_SIZE = 3;
	public const int SAMPLE_COUNT = 5;

	private int [,] Sample = {
		{ KEY_DOWN, KEY_RIGHT, KEY_DOWN, KEY_RIGHT, KEY_FIRT },
		{ KEY_DOWN, KEY_RIGHT, KEY_DOWN, KEY_LEFT, KEY_FIRT },
		{ KEY_DOWN, KEY_LEFT, KEY_DOWN, KEY_LEFT, KEY_FIRT },
	};

	private int currentKeyCode = 0;
	private bool startFrame = false;
	private int currentFrame = 0;
	private List<int> playerSample;
	private bool isSuccess = false;

	// Use this for initialization
	void Start () {
		playerSample = new List<int> ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateKey();

		if (Input.anyKeyDown) {
			if (isSuccess) {
				isSuccess = false;
				Reset();
			}

			if (!startFrame) {
				startFrame = true;
			}

			playerSample.Add(currentKeyCode);

			int size = playerSample.Count;

			if (size == SAMPLE_COUNT) {
				for (int i = 0; i < SAMPLE_SIZE; i++) {
					int successCount = 0;
					for (int j = 0; j < SAMPLE_COUNT; j++) {
						int tmp = playerSample[j];
						if (tmp == Sample[i, j]) {
							successCount++;
						}
					}

					if (successCount == SAMPLE_COUNT) {
						isSuccess = true;
						break;
					}
				}
			}
		}

		if (startFrame) {
			currentFrame++;
		}

		if (currentFrame >= FRAME_COUNT) {
			if (!isSuccess) {
				Reset();
			}
		}
	}

	void OnGUI () {
		int size = playerSample.Count;

		for (int i = 0; i < size; i++) {
			int key = playerSample[i];
			Texture tmp = null;
			switch (key) {
			case KEY_UP:
				tmp = imageUp;
				break;
			case KEY_DOWN:
				tmp = imageDown;
				break;
			case KEY_LEFT:
				tmp = imageLeft;
				break;
			case KEY_RIGHT:
				tmp = imageRight;
				break;
			}

			if (tmp != null) {
				GUILayout.Label(tmp);
			}
		}

		if (isSuccess) {
			GUILayout.Label(imageSuccess);
		}

		GUILayout.Label("Combine Key 1: DOWN, RIGHT, DOWN, RIGHT, FIRT");
		GUILayout.Label("Combine Key 2: DOWN, RIGHT, DOWN, LEFT, FIRT");
		GUILayout.Label("Combine Key 3: DOWN, LEFT, DOWN, LEFT, FIRT");
	}

	void UpdateKey() {
		if (Input.GetKeyDown(KeyCode.W)) {
			currentKeyCode = KEY_UP;
		}

		if (Input.GetKeyDown(KeyCode.S)) {
			currentKeyCode = KEY_DOWN;
		}

		if (Input.GetKeyDown(KeyCode.A)) {
			currentKeyCode = KEY_LEFT;
		}

		if (Input.GetKeyDown(KeyCode.D)) {
			currentKeyCode = KEY_RIGHT;
		}

		if (Input.GetKeyDown(KeyCode.F)) {
			currentKeyCode = KEY_FIRT;
		}
	}

	void Reset() {
		currentFrame = 0;
		startFrame = false;
		playerSample.Clear();
	}
}
