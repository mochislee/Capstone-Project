using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options; 
    public int currentQuestion; 

    public GameObject QuizPanel;
    public GameObject GoPanel;

    public UnityEngine.UI.Text QuestionTxt; 
     public UnityEngine.UI.Text ScoreTxt; 

     int totalQuestions=0; 
     public int score; 

    private void Start()
    {       
            totalQuestions = QnA.Count; 
            GoPanel.SetActive(false);
            generateQuestion();
    }

     void GameOver()
     {      QuizPanel.SetActive(false);
            GoPanel.SetActive (true);
            ScoreTxt.text = score + "/" +  totalQuestions;

     }


     public void Next()
     {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
     }

    public void correct()
    {
        score +=1; 
         QnA.RemoveAt(currentQuestion);
         generateQuestion();
    }


    public void wrong(){
       QnA.RemoveAt(currentQuestion);
         generateQuestion();
    }

    void SetAnswers(){

        for (int i = 0; i <options.Length; i++) 
        {

            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text= QnA[currentQuestion].Answer[i]; 

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                  options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
    }
    }


    void generateQuestion()
    {
        if (QnA.Count > 0){

            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question; 
            SetAnswers();

        }

        else {
            Debug.Log("Out of Question");
            GameOver();
        }
    

   
    }
}
