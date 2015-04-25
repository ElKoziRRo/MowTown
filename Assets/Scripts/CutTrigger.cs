using UnityEngine;
using System.Collections;

public class CutTrigger : MonoBehaviour {

	public GameObject trimmedGrassPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider){
		GameObject trimmedGrass;
		if (collider.tag == "sword") {
			trimmedGrass = (GameObject) Instantiate (trimmedGrassPrefab);
		}
	}
}
