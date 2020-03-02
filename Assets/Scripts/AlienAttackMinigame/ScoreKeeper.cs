using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private int score = 0; //Set the score to 0 at the beginning
    public Text scoreUIField;

    void Start()
    {
        ResetScore();
        scoreUIField.text = "" + score;
    }

    void Update()
    {
        scoreUIField.text = "" + score.ToString();
    }

    public void AddToScore(int amount)
    {
        score += amount;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
