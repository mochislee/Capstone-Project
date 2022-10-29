using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject rightAnswer;
    public GameObject wrongAnswer;

    public GameObject FlashPanel;
    public UnityEngine.UI.Text FlashText;

    private void OnEnable()
    {
        //AnswerScript.OnRightAnswer += EnableRightAnswer;
        //AnswerScript.OnWrongAnswer += EnableWrongAnswer;
    }

    /*public void EnableRightAnswer()
    {
        rightAnswer.SetActive(true);
        FlashText.text = "May Tama ka!";
        Destroy(rightAnswer, 3);
    }

    public void EnableWrongAnswer()
    {
        wrongAnswer.SetActive(true);
        FlashText.text = "May Tama ka!";
        Destroy(wrongAnswer, 3);
    }*/
}
