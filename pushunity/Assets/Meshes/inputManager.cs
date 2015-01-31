using UnityEngine;
using System.Collections;
public class inputManager : MonoBehaviour
{
	public GameObject player;
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
	//public GameObject Room;
	public GameObject button;

    private int[] theDeck;  //Setting up theDeck array

//    public GameObject player;

    private void Start()
    {
				theDeck = new int[36]; //Add 26 ints to array theDeck


				for (var i = 0; i < theDeck.Length; i++) {
						theDeck [i] = i + 1;
				}

				Shuffle ();
    

//				Room = GameObject.FindGameObjectWithTag ("Room");
				player.transform.localScale = new Vector3 (2, 2, 2);
				isocamera.enabled = true;
				fpscamera.enabled = false;
				orthocamera1.enabled = false;
				orthocamera2.enabled = false;
				orthocamera3.enabled = false;
				this.transform.gameObject.GetComponent<ParticleSystem> ().emissionRate = 0;
		}

    private void Shuffle()
    {
        for (var i = 0; i < theDeck.Length; i++)
        {
            var temp = theDeck[i];
            var randomIndex = Random.Range(0, theDeck.Length);

            theDeck[i] = theDeck[randomIndex];
            theDeck[randomIndex] = temp;
        }
    }



    private void Update()
    {

		/*if (Input.GetButtonDown ("27")) {
			audio.Play();
				}*/


        var theNumber = 0;

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
				player.rigidbody.AddForce (Vector3.up * 100 * multi);
				print ("global jump");
                break;

            case 2: //MOVE
                print(theNumber);
				player.rigidbody.AddRelativeForce (Vector3.back * 100 * multi);
				print ("local back");
                break;
           
			case 3:
                print(theNumber);
				player.rigidbody.AddRelativeForce (Vector3.up * 100 * multi);
				print ("global jump");	
                break;
            
			case 4:
                print(theNumber);
				player.rigidbody.AddRelativeTorque (Vector3.up * 200);
				print ("local jump");
                break;
            
			case 5:
                print(theNumber);
				if (player.rigidbody.freezeRotation == false) {
					player.rigidbody.freezeRotation = true;
					print ("topplelock engaged");
				} else {
					player.rigidbody.freezeRotation = false;
                	
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
				player.transform.localScale = new Vector3 (1 * scale, 1 * scale, 1 * scale);
					}
				print ("scale up");
                break;

            case 13:
                print(theNumber);
				if (scale >= 2){
				scale --;
				player.transform.localScale = new Vector3 (scale / 1, scale / 1, scale / 1);
					}
				print ("scale down");
                break;

            case 14:
                print(theNumber);
				spawn = GameObject.FindGameObjectsWithTag ("Player").Length;
				if (spawn < 2) {
					Instantiate (player);}
				print ("clone player");
                break;

            case 15:
                print(theNumber);
				//Room.transform.Rotate (Vector3.right * 200);
				print ("room rotate");
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
				player.rigidbody.AddExplosionForce(1000,this.transform.position,500.0f,3.0f);
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
					isocamera.orthographicSize = 2;
					zoom = true;}
				else {
					isocamera.orthographicSize = 5;
					zoom = false;}
					print ("Zoom");
                break;
            case 26:
                print(theNumber);
				if(zoom2 == false){
					isocamera.orthographicSize = 40;
					zoom2 = true;}
				else {
					isocamera.orthographicSize = 5;
					zoom2 = false;}
					print ("zoom out");
                break;
			case 27:

			print ("room rotate");
				break;
			case 28:
			
					print ("room rotate");
				break;
			
			case 29:
			
					print ("room rotate");
				break;
			
			case 30:
			
					print ("room rotate");
				break;
			
			case 31:
			
					print ("room rotate");
				break;
			
			case 32:
			
					print ("room rotate");
				break;
			
			case 33:
			
					print ("room rotate");
				break;
			
			case 35:
			
					print ("room rotate");
				break;
			
			case 36:
			
					print ("room rotate");
				break;
			
			case 37:
			
					print ("room rotate");
				break;
			

            default:
                break;
       }

	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "button")
			Application.LoadLevel (1);
	}
	
	/*void OncollisionEnter(Collision other){
		audio.Play ();
		print ("hit");
	}*/
  }