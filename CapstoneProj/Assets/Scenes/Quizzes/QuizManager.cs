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
    public UnityEngine.UI.Text Message;  

    public Button RetryBtn;
    public Button NextBtn;

    public GameObject buttonRetry;
    public GameObject buttonNext;

    public GameObject FlashPanel;
    public UnityEngine.UI.Text FlashText;

    private float Timer;
    private bool Answer;

    int totalQuestions = 0; 
    public int score; 

    private void Start()
    {       
            totalQuestions = QnA.Count; 
            GoPanel.SetActive(false);
            generateQuestion();
            Answer = true;
            Timer = 0;
    }

    private void Update()
    {
        Timer += Time.deltaTime;

        if (Answer)
        {
            if (Timer >= 2)
            {
                FlashPanel.SetActive(false);               
                Timer = 0;
            }
        }
    }


//last panel / updates
    void GameOver()
     {      QuizPanel.SetActive(false);
            GoPanel.SetActive (true);
            ScoreTxt.text = score + "/" +  totalQuestions;

//retry
            if(score <= 2){
                buttonNext.SetActive(false);
                Message.text = "Subukan Muli: Basahin mabuti ang mga salita. Ang mga kasagutan ay manggaling sa mga Naka-highlight.";
                Button Rbtn = NextBtn.GetComponent<Button>();
		        Rbtn.onClick.AddListener(Retry);
            }

//continue next scene
            else{
                buttonRetry.SetActive(false);
                Message.text = "Mahusay! Maaari ka nang magpatuloy.";
                Button Nbtn = NextBtn.GetComponent<Button>();
		        Nbtn.onClick.AddListener(Next);
            }

     }

//method scene changer
     public void Next()
     {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
     }

     public void Retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

//right wrong method

    public void correct()
    {

            FlashPanel.SetActive(true);
            FlashText.text = "May Tama ka!";
            score += 1;
            Answer = true;
            QnA.RemoveAt(currentQuestion);
            generateQuestion();
    }

    public void wrong()
    {
            FlashPanel.SetActive(true);
            FlashText.text = "May Mali ka!";
            Answer = true;
            QnA.RemoveAt(currentQuestion);
            generateQuestion();
    }

//Answers
    void SetAnswers(){

        for (int i = 0; i < options.Length; i++) 
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = QnA[currentQuestion].Answer[i]; 

            if(QnA[currentQuestion].CorrectAnswer == i)
            {
                  options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

//generate randomized Questions
    void generateQuestion()
    {
        if (QnA.Count > 0){

            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question; 
            SetAnswers();

        }

        else {
            Debug.Log("End of Quiz");
            GameOver();
        }
    }
}
