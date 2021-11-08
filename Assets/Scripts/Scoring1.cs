using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoring1 : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Scores " + score;
    }
}
