using UnityEngine;
using System.Collections;
using System.Net.NetworkInformation;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Animator anim;

    public bool acceptInput = true;
    public static bool OnWin = false;

	public float timer = 1;
	public int buttonPresses = 1;
	public float keyPresses = 1;

    public static float theScore = 1000;

    public GameObject MainCam;
    //Text finalScore;
    float _blurLevel;

	// Use this for initialization
	void Start ()
	{
	    //finalScore = GetComponent<Text>();
	}
	
	// Update is called once per frame
    private void Update()
    {
        //print(theScore);

        if (OnWin && _blurLevel<=0.5f)
        {
            _blurLevel += 0.01f;
            MainCam.GetComponent<DepthOfFieldScatter>().aperture += _blurLevel;
            //finalScore.text = (theScore.ToString());
        }

        else if (_blurLevel >= 0.5f)
        {
            anim.SetTrigger("OnWin");
        }

        else if (!OnWin)
        {

            timer += Time.deltaTime;
            if (theScore > 0)
            {
                theScore = (timer*-3) + (keyPresses*-10) + 1000;
            }
            else
            {

                theScore = 0;
            }
            timer += Time.deltaTime;
            //print(timer);

            if (Input.anyKeyDown)
            {
                keyPresses += 1;
            }

            if (buttonPresses >= 1)
            {
                acceptInput = false;
            }

        }

    }

}

