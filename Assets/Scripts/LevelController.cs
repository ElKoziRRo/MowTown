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
		Vector3 position = new Vector3 ();

		for (int i = -13; i < 13; i++) {
			if (i >-2 && i < 1 ) continue;
			for (int j = -6; j < 6; j++) {
				position.x = i * 0.64f + 0.32f;
				position.y = j * 0.64f + 0.32f;
				Instantiate( grassPrefab, position, new Quaternion() );
			}
		}
	}
}
