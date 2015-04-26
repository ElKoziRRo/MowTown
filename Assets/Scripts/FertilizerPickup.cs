using UnityEngine;
using System.Collections;

public class FertilizerPickup : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D ( Collider2D collider) {
		if (collider.tag == "Player") {
			transform.position = new Vector3(collider.transform.position.x, collider.transform.position.y + 0.32f, 0);
			transform.parent = collider.transform;
			GetComponentInParent<PlayerController>().PickupFert();
		}
	}
}
