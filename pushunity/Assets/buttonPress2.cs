using UnityEngine;
using System.Collections;

public class buttonPress2 : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			anim.SetTrigger("pressed");

			other.rigidbody.AddForce( Vector3.forward * 2000);
		}
	}
}
