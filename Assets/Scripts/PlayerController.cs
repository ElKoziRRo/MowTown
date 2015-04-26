using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject sword;
	public float attackCooldown;
	public string x;
	public string a;

	private Rigidbody2D r;
	private bool attacking = false;
	private float attackTime;

	// Use this for initialization
	void Start () {
		attackTime = attackCooldown;
		r = GetComponent<Rigidbody2D> ();
		sword.transform.position = new Vector3 (sword.transform.parent.transform.position.x, 
		                                        sword.transform.parent.transform.position.y - 0.32f);
	}
	
	// Update is called once per frame
	void Update () {

		Attack ();

		if (Mathf.Abs(r.velocity.x) > Mathf.Abs(r.velocity.y)) {
			if( r.velocity.x > 0)
				sword.transform.position = new Vector3 (sword.transform.parent.transform.position.x + 0.32f, 
				                                       sword.transform.parent.transform.position.y);
			else if (r.velocity.x < 0)
				sword.transform.position = new Vector3 (sword.transform.parent.transform.position.x - 0.32f, 
				                                       sword.transform.parent.transform.position.y);
		}
		else if (Mathf.Abs(r.velocity.x) < Mathf.Abs(r.velocity.y)) {
			if( r.velocity.y > 0)
				sword.transform.position = new Vector3 (sword.transform.parent.transform.position.x, 
				                                        sword.transform.parent.transform.position.y + 0.32f);
			else if (r.velocity.y < 0)
				sword.transform.position = new Vector3 (sword.transform.parent.transform.position.x, 
				                                         sword.transform.parent.transform.position.y - 0.32f);
		} 
	}

	void Attack(){
		if (!attacking) {
			if (Input.GetButtonDown (a) || Input.GetButtonDown (x)) {
				attacking = true;
				sword.SetActive(true);
				r.velocity = new Vector3();
			}
		}else {
			attackTime -= Time.deltaTime;
			if (attackTime <= 0) {
				attackTime = attackCooldown;
				attacking = false;
				sword.SetActive(false);
			}
		}
	}

	public bool isAttacking(){
		return attacking;
	}

}
