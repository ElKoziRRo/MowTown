using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	
	public GameObject grassPrefab;
	//public GameObject bushPrefab;

	// Use this for initialization
	void Start () {
		PrepareLevel ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void PrepareLevel() {
		GameObject currentTile;
		Vector3 position = new Vector3 ();
		for (int i = -12; i < 13; i++) {
			if (i >-2 && i < 2 ) continue;
			for (int j = -6; j < 7; j++) {
				position.x = i * 0.64f;
				position.y = j * 0.64f;
				currentTile = (GameObject) Instantiate( grassPrefab, position, new Quaternion() );
			}
		}
	}
}
