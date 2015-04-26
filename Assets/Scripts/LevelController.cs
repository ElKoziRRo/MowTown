using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	
	public GameObject grassPrefab;
	public GameObject concretePrefab;
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

		for (int i = -14; i < 14; i++) {
			if (i >-2 && i < 1 ) {
				for (int j = -8; j < 8; j++) {
					position.x = i * 0.64f + 0.32f;
					position.y = j * 0.64f + 0.32f;
					Instantiate( concretePrefab, position, new Quaternion() );
				}
			}
			else {
				for (int j = -8; j < 8; j++) {
					position.x = i * 0.64f + 0.32f;
					position.y = j * 0.64f + 0.32f;
					if ( j < -7 || j > 4 || i < -13 || i > 12)
						Instantiate( concretePrefab, position, new Quaternion() );
					else
						Instantiate( grassPrefab, position, new Quaternion() );
				}

			}
		}
	}
}
