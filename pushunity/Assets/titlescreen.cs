using System;
using UnityEngine;
using System.Collections;


public class titlescreen : MonoBehaviour
{

    public MovieTexture introMovie;
    //public bool loop;

	// Use this for initialization
	void Start ()
	{

        renderer.material.mainTexture = introMovie;
        introMovie.Play();
	    //introMovie.loop = loop;

	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > 13 || Input.GetKeyDown("space"))
	    {
	        Application.LoadLevel("menu");
	    }
	    //Debug.Log(Time.time);
	}
}
