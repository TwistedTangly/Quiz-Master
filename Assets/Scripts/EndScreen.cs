using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;
    Quiz quiz;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        quiz = FindObjectOfType<Quiz>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations\nYou got " + scoreKeeper.GetCorrectAnswers() +" / " + quiz.NumberOfQuestions() + " Correct" ;
    }

   
}
