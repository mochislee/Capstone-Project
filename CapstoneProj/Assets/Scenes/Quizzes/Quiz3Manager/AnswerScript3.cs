using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript3 : MonoBehaviour
{

    public bool isCorrect = false; 
    public QuizManager3 quizManager;
    


    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Tama");
            quizManager.correct();
            

        }
        else
        {
             Debug.Log("Mali");
             quizManager.wrong();
        }


    }
}
