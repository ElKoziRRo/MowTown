using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject sword;

	// Use this for initialization
	void Start () {
		sword.transform.position = new Vector3 (-0.32f, 0);
	}
	
	// Update is called once per frame
	void Update () {

	}


}
