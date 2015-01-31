using UnityEngine;
using System.Collections;

public class shootToast : MonoBehaviour {
	float timer = 1.0f;
	public Rigidbody toast;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if(timer <= 0) {
			Rigidbody clone;
			clone = Instantiate(toast, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * 20);
			timer = 1.0f;
		}
	}
}
