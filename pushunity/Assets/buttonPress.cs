using UnityEngine;
using System.Collections;

public class buttonPress : MonoBehaviour {
	public Animator anim;
    public GameObject scoreActivate;
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			anim.SetTrigger("pressed");
            other.rigidbody.AddForce( Vector3.forward * 2000);
		    Debug.Log("Win!");
		    StartCoroutine(buttonPause());


		}
	}

    IEnumerator buttonPause()
    {
        yield return new WaitForSeconds(1);
        score.OnWin = true;
    }


}
