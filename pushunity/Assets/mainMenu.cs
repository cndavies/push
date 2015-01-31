using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	public void campaignStart () {
	    Application.LoadLevel("inputTest");
	}
	
	// Update is called once per frame
	public void exitButton () {
	    Application.Quit();

	}
}
