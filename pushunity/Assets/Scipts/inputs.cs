using UnityEngine;
using System.Collections;
public class inputs : MonoBehaviour
{

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
	

	public GameObject Player;
	public PhysicMaterial playerphm;
	public PhysicMaterial bounceroom;
	public GameObject bouncyball;
	private int multi = 1;
	private bool zoom = false;
	private bool zoom2 = false;
	public bool grade1 = true;
	public bool grade2 = true;
	public bool xgrav = true;
	public bool ygrav = true;
	public bool zgrav = true;
	public int scale = 2;
	public int spawn;
	public int balls;
	public int orthocam = 1;
	public Camera fpscamera;
	public Camera isocamera;
	public Camera orthocamera1;
	public Camera orthocamera2;
	public Camera orthocamera3;
	public AudioClip thud;
	public GameObject room;
	public GameObject button;
	public AudioSource Intercom;
	public AudioSource Music;
	
	private int[] theDeck;  //Setting up theDeck array
	
	//    public GameObject player;
	
	private void Start()
	{
		Player = GameObject.FindGameObjectWithTag("Player");

		theDeck = new int[36]; //Add 26 ints to array theDeck
		
		
		for (int i = 0; i < theDeck.Length; i++) {
			theDeck [i] = i + 1;
		}
		
		Shuffle ();
		
		
		//				Room = GameObject.FindGameObjectWithTag ("Room");
		//Player.gameObject.transform.localScale = new Vector3 (2, 2, 2);
		isocamera.enabled = true;
		fpscamera.enabled = false;
		orthocamera1.enabled = false;
		orthocamera2.enabled = false;
		orthocamera3.enabled = false;
		//Intercom.enabled = false;
		this.transform.gameObject.GetComponent<ParticleSystem> ().emissionRate = 0;
	}
	
	private void Shuffle()
	{
		for (int i = 0; i < theDeck.Length; i++)
		{
			int temp = theDeck[i];
			//int randomIndex = Random.Range(0, theDeck.Length);
			
			//theDeck[i] = theDeck[randomIndex];
			//theDeck[randomIndex] = temp;
		}
	}
	
	
	
	private void Update()
	{
		
		/*if (Input.GetButtonDown ("27")) {
			audio.Play();
				}*/
		
		
		int theNumber = 0;
		
		if (Input.GetButtonDown("1"))
		{
			theNumber = theDeck[0];
		}
		else if (Input.GetButtonDown("2"))
		{
			theNumber = theDeck[1];
		}
		else if (Input.GetButtonDown("3"))
		{
			theNumber = theDeck[2];
		}
		else if (Input.GetButtonDown("4"))
		{
			theNumber = theDeck[3];
		}
		else if (Input.GetButtonDown("5"))
		{
			theNumber = theDeck[4];
		}
		else if (Input.GetButtonDown("6"))
		{
			theNumber = theDeck[5];
		}
		else if (Input.GetButtonDown("7"))
		{
			theNumber = theDeck[6];
		}
		else if (Input.GetButtonDown("8"))
		{
			theNumber = theDeck[7];
		}
		else if (Input.GetButtonDown("9"))
		{
			theNumber = theDeck[8];
		}
		else if (Input.GetButtonDown("10"))
		{
			theNumber = theDeck[9];
		}
		else if (Input.GetButtonDown("11"))
		{
			theNumber = theDeck[10];
		}
		else if (Input.GetButtonDown("12"))
		{
			theNumber = theDeck[11];
		}
		else if (Input.GetButtonDown("13"))
		{
			theNumber = theDeck[12];
		}
		else if (Input.GetButtonDown("14"))
		{
			theNumber = theDeck[13];
		}
		else if (Input.GetButtonDown("15"))
		{
			theNumber = theDeck[14];
		}
		else if (Input.GetButtonDown("16"))
		{
			theNumber = theDeck[15];
		}
		else if (Input.GetButtonDown("17"))
		{
			theNumber = theDeck[16];
		}
		else if (Input.GetButtonDown("18"))
		{
			theNumber = theDeck[17];
		}
		else if (Input.GetButtonDown("19"))
		{
			theNumber = theDeck[18];
		}
		else if (Input.GetButtonDown("20"))
		{
			theNumber = theDeck[19];
		}
		else if (Input.GetButtonDown("21"))
		{
			theNumber = theDeck[20];
		}
		else if (Input.GetButtonDown("22"))
		{
			theNumber = theDeck[21];
		}
		else if (Input.GetButtonDown("23"))
		{
			theNumber = theDeck[22];
		}
		else if (Input.GetButtonDown("24"))
		{
			theNumber = theDeck[23];
		}
		else if (Input.GetButtonDown("25"))
		{
			theNumber = theDeck[24];
		}
		else if (Input.GetButtonDown("26"))
		{
			theNumber = theDeck[25];
		}
		
		else if (Input.GetButtonDown("27"))
		{
			theNumber = theDeck[26];
		}
		else if (Input.GetButtonDown("28"))
		{
			theNumber = theDeck[27];
		}
		else if (Input.GetButtonDown("29"))
		{
			theNumber = theDeck[28];
		}
		else if (Input.GetButtonDown("30"))
		{
			theNumber = theDeck[29];
		}
		else if (Input.GetButtonDown("31"))
		{
			theNumber = theDeck[30];
		}
		else if (Input.GetButtonDown("32"))
		{
			theNumber = theDeck[31];
		}
		else if (Input.GetButtonDown("33"))
		{
			theNumber = theDeck[32];
		}
		else if (Input.GetButtonDown("34"))
		{
			theNumber = theDeck[33];
		}
		else if (Input.GetButtonDown("35"))
		{
			theNumber = theDeck[34];
		}
		else if (Input.GetButtonDown("36"))
		{
			theNumber = theDeck[35];
		}
		else
		{
			theNumber = 0;
		}
		
		
		switch (theNumber)
		{
		case 1: //JUMP
			print(theNumber);
			Player.rigidbody.AddRelativeForce (Vector3.forward * 500 * multi);
			print ("local back ");
			break;
			
		case 2: //MOVE
			print(theNumber);
			Player.rigidbody.AddRelativeForce (Vector3.back * 500 * multi);
			print ("local forward");
			break;
			
		case 3:
			print(theNumber);
			Player.rigidbody.AddRelativeForce (Vector3.up * 500 * multi);
			print ("local jump");	
			break;
			
		case 4:
			print(theNumber);
			Player.rigidbody.AddRelativeTorque (Vector3.up * 700);
			print ("local spin");
			break;
			
		case 5:
			print(theNumber);
			if (Player.rigidbody.freezeRotation == false) {
				Player.rigidbody.freezeRotation = true;
				print ("topplelock engaged");
			} else {
				Player.rigidbody.freezeRotation = false;
				
			}
			break;
		case 6:
			print(theNumber);
			if (playerphm.bounciness == .9f) {
				playerphm.bounciness = 0;
				print ("bounce disabled");
			} else {
				playerphm.bounciness = .9f;
				print ("bounce enabled");
			}
			break;
			
		case 7:
			print(theNumber);
			if(grade1 == true) {
				multi *= 2;
				grade1 = false;
				print ("X2!");}
			break;
			
		case 8:
			print(theNumber);
			if (xgrav == true) {
				Physics.gravity = new Vector3 (-10, 0, 0);
				xgrav = false;
				print (" X gravity");
			} else {
				Physics.gravity = -Physics.gravity;
				print ("flipped gravity");
				xgrav = true;
			}
			break;
			
		case 9:
			print(theNumber);
			if (ygrav == true) {
				Physics.gravity = new Vector3 (0, -10, 0);
				ygrav = false;
				print ("Y gravity");
			} else {
				Physics.gravity = -Physics.gravity;
				print ("flipped gravity");
				ygrav = true;
			}
			break;
			
		case 10:
			print(theNumber);
			if (zgrav == true) {
				Physics.gravity = new Vector3 (0, 0, -10);
				zgrav = false;
				print (" Z gravity");
			} else {
				Physics.gravity = -Physics.gravity;
				print ("flipped gravity");
				zgrav = true;
			}
			break;
			
		case 11:
			print(theNumber);
			Physics.gravity = new Vector3 (0, 0, 0);
			print ("no gravity");
			break;
			
		case 12:
			print(theNumber);
			if (scale <= 2){
				scale ++;
				Player.transform.localScale = new Vector3 (1 * scale, 1 * scale, 1 * scale);
			}
			print ("scale up");
			break;
			
		case 13:
			print(theNumber);
			if (scale >= 2){
				scale --;
				Player.transform.localScale = new Vector3 (scale / 1, scale / 1, scale / 1);
			}
			print ("scale down");
			break;
			
		case 14:
			print(theNumber);
			spawn = GameObject.FindGameObjectsWithTag ("Player").Length;
			if (spawn < 2) {
				Instantiate (Player);}
			print ("clone player");
			break;
			
		case 15:
			print(theNumber);
				/*if (Intercom.enabled == true){
					Intercom.enabled = false;
					Music.volume = 1;
				}else if (Intercom.enabled == false){
					Intercom.enabled = true;
					Music.volume = .5f;	}*/
			Intercom.Play();
			Music.volume = .2f;
			print ("VOID");
			break;
			
		case 16:
			print(theNumber);
			if(grade2 == false){
				multi *= 2;
				grade2 = false;}
			print ("X2");
			break;
			
		case 17:
			print(theNumber);
			balls = GameObject.FindGameObjectsWithTag ("balls").Length;
			if (balls < 30) {
				for (int i = balls; i < 30; i++) {
					Rigidbody ball;
					ball = Instantiate (bouncyball, transform.position, transform.rotation) as Rigidbody;
				}
			}
			print ("balls");
			break;
			
		case 18:
			print(theNumber);
			fpscamera.enabled = true;	
			isocamera.enabled = false;
			orthocamera1.enabled = false;
			orthocamera2.enabled = false;
			orthocamera3.enabled = false;
			print ("camera fps");
			break;
			
		case 19:
			print(theNumber);
			isocamera.enabled = true;	
			fpscamera.enabled = false;
			orthocamera1.enabled = false;
			orthocamera2.enabled = false;
			orthocamera3.enabled = false;
			print ("camera iso");
			break;
			
		case 20:
			print(theNumber);
			fpscamera.enabled = false;	
			isocamera.enabled = false;
			if (orthocam == 1) {
				orthocamera3.enabled = false;				
				orthocamera1.enabled = true;
				orthocam++;
			} else if (orthocam == 2) {
				orthocamera1.enabled = false;
				orthocamera2.enabled = true;
				orthocam++;
			} else if (orthocam == 3) { 
				orthocamera2.enabled = false;
				orthocamera3.enabled = true;
				orthocam = 1;
			}
			print ("ortho camera");
			break;
		case 21:
			print(theNumber);
			if (Time.timeScale == 1.0F){
				Time.timeScale = 0.5F;
				print ("time slow");}
			else
				Time.timeScale = 1.0F;
			break;
		case 22:
			print(theNumber);
			this.transform.gameObject.GetComponent<ParticleSystem>().emissionRate = 70;
			multi *= 4;
			print ("FIRE");
			break;
		case 23:
			print(theNumber);
			Player.rigidbody.AddExplosionForce(1000,this.transform.position,500.0f,3.0f);
			print ("Explode");
			break;
		case 24:
			print(theNumber);
			if (bounceroom.bounciness == 1) {
				bounceroom.bounciness = 0;
				bounceroom.bounceCombine = PhysicMaterialCombine.Minimum;
				print ("bounceroom disabled");
			} else {
				bounceroom.bounciness = 1;
				bounceroom.bounceCombine = PhysicMaterialCombine.Maximum;
				print ("bounce room enabled");
			}
			break;
		case 25:
			print(theNumber);
			if(zoom == false){
				isocamera.orthographicSize = 25;
				zoom = true;}
			else {
				isocamera.orthographicSize = 100;
				zoom = false;}
			print ("Zoom");
			break;
		case 26:
			print(theNumber);
			if(zoom2 == false){
				isocamera.orthographicSize = 400;
				zoom2 = true;}
			else {
				isocamera.orthographicSize = 100;
				zoom2 = false;}
			print ("zoom out");
			break;
		case 27:
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
			break;

		case 28:
			if (!isInvis){
				GameObject.FindGameObjectWithTag("Player").renderer.material = invisMaterial;
				isInvis = !isInvis;
			} else {
				GameObject.FindGameObjectWithTag("Player").renderer.material = originalMaterial;
				isInvis = !isInvis;
			}
			break;

		case 29:
			GameObject[] objects2;
			
			//Array.Clear(objects, 0, objects.Length);
			objects2 = GameObject.FindGameObjectsWithTag("Destroy");
			
			if (objects2[0] != null){
				int num = Random.Range(0,objects2.Length);
				Vector3 pos = objects2[num].transform.position;
				foreach(GameObject obj in objects2){
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
			break;
		case 30:
			
			foreach (GameObject child in hats) {
				child.SetActive(false);
			}
			
			int num2 = Random.Range(0,hats.Length);
			hats[num2].SetActive(true);
			break;
		case 31:
			
			money.SetActive(true);
			break;
		case 32:
			
			if (GameObject.FindGameObjectWithTag("Toaster") == null) {
				GameObject clone;
				clone = Instantiate(toaster, GameObject.FindGameObjectWithTag("Player").transform.position, transform.rotation) as GameObject;
			}
			break;
			
		case 33:
			
			print(theNumber);
			if (Time.timeScale == 1.0F){
				Time.timeScale = 1.5F;
				print ("time fast");}
			else
				Time.timeScale = 1.0F;
			break;
			
		case 35:
			
			print ("void");
			break;
			
		case 36:
			
			print ("void");
			break;
			
		case 37:
			
			print ("void");
			break;
			
			
		default:
			break;
		}
		
	}
	
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "button")
						Application.LoadLevel (1);
				else if (other.gameObject.tag == "Respawn")
						Application.LoadLevel (0);
	}


	/*void OncollisionEnter(Collision other){
		audio.Play ();
		print ("hit");
	}*/
}