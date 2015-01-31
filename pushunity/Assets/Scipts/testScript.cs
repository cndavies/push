using UnityEngine;

using System.Collections;

public class testScript : MonoBehaviour {

	public Material originalMaterial;
	public Material invisMaterial;
	public Mesh buttonMesh;
	public Material buttonMaterial;
	bool isInvis = false;
	public GameObject explode;
	public GameObject money;
	public GameObject[] hats;
	public bool rainMoney = false;
	public GameObject toaster;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("1")) {
			toast();
		}

	}

	void destroySomething(){
		GameObject[] objects;

		//Array.Clear(objects, 0, objects.Length);
		objects = GameObject.FindGameObjectsWithTag("Destroy");

		if (objects[0] != null){
			int num = Random.Range(0,objects.Length);
			Vector3 pos = objects[num].transform.position;

			GameObject explosion;
			explosion = Instantiate(explode, pos, transform.rotation) as GameObject;
			//objects[num].rigidbody.AddExplosionForce(50.0f, pos, 10.0f, 0.0F);
	
			Destroy(objects[num]);
		}
	}

	void makeInvisible(){
		if (!isInvis){
			GameObject.FindGameObjectWithTag("Player").renderer.material = invisMaterial;
			isInvis = !isInvis;
		} else {
			GameObject.FindGameObjectWithTag("Player").renderer.material = originalMaterial;
			isInvis = !isInvis;
		}
	}

	void makeButtons(){
		GameObject[] objects;
		
		//Array.Clear(objects, 0, objects.Length);
		objects = GameObject.FindGameObjectsWithTag("Destroy");
		
		if (objects[0] != null){
			int num = Random.Range(0,objects.Length);
			Vector3 pos = objects[num].transform.position;
			foreach(GameObject obj in objects){
				if (obj.transform.gameObject.GetComponent<MeshCollider>() != null) {

				obj.transform.gameObject.GetComponent<MeshFilter>().mesh = buttonMesh;
				obj.transform.gameObject.renderer.material = buttonMaterial;
				obj.transform.gameObject.GetComponent<MeshCollider>().mesh = buttonMesh;
		
				obj.transform.localScale = new Vector3 (40.2f, 40.2f, 10.12f);
					obj.transform.gameObject.rigidbody.AddForce(Vector3.up * 20);
				}
			}

			GameObject.FindGameObjectWithTag("Button").rigidbody.isKinematic = false;
			GameObject.FindGameObjectWithTag("Button").rigidbody.AddForce(Vector3.forward * 10);
		}
	}

	void newHat () {

		foreach (GameObject child in hats) {
			child.SetActive(false);
		}

		int num = Random.Range(0,hats.Length);
		hats[num].SetActive(true);

	}

	void makeItRain () {

		money.SetActive(true);
		
	}

	void toast () {
		if (GameObject.FindGameObjectWithTag("Toaster") == null) {
			GameObject clone;
			clone = Instantiate(toaster, GameObject.FindGameObjectWithTag("Player").transform.position, transform.rotation) as GameObject;
		}


	}
}
