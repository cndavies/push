using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreUpdate : MonoBehaviour
{

    Text finalScore;

	// Use this for initialization
    void Start()
    {

        finalScore = GetComponent<Text>();
        

    }

    // Update is called once per frame
    void Update()
    {
        int finalScoreInt = Convert.ToInt32(score.theScore);
        finalScore.text = (finalScoreInt.ToString());

    }

    public void PromotionClicked()

    {
            //nextLevel
        score.OnWin = false;
        Application.LoadLevel("inputTest");
    }


}
