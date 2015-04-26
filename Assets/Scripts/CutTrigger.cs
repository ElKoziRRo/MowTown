using UnityEngine;
using System.Collections;

public class CutTrigger : MonoBehaviour {

	public GameObject trimmedGrassPrefab;
	public GameObject grassBladesPrefab;
	public AudioClip[] cutClips;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider){
		if (collider.tag == "Sword") {
			Cut ();
		}
	}

	public void Cut(){
		AudioSource.PlayClipAtPoint(cutClips[Random.Range (0 ,cutClips.Length)], transform.position);
		Instantiate (trimmedGrassPrefab, transform.position, new Quaternion());
		Instantiate (grassBladesPrefab, transform.position, new Quaternion(180, 0, 0, 1) );
		Destroy (gameObject);
	}
}
