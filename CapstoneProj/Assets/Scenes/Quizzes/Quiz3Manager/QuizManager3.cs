using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class QuizManager3 : MonoBehaviour
{
    public List<QuestionsAndAnswers3> QnA;
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
    [SerializeField] public int points; 
    [SerializeField] public string proficient;
    InputHandler2 ihandler;

    private void Start()
    {       
            totalQuestions = QnA.Count; 
            GoPanel.SetActive(false);
            generateQuestion();
            Answer = true;
            Timer = 0;
            ihandler = GameObject.Find("Proficiency Manager").GetComponent<InputHandler2>();
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
            ScoreTxt.text = points + "/" +  totalQuestions;
            displayProficiency();
            ihandler.AddNameToList();

//retry
            if(points == 7){
                buttonRetry.SetActive(false);
                Message.text = "Mahusay! Nahuli mo ang Ibong Adarna.";
                Button Nbtn = NextBtn.GetComponent<Button>();
		        Nbtn.onClick.AddListener(Next);
                
            }

//continue next scene
            else{
              buttonNext.SetActive(false);
                Message.text = "Naging Bato si Don Juan. Subukan na makakuha ng perpektong Puntos";
                Button Rbtn = NextBtn.GetComponent<Button>();
		        Rbtn.onClick.AddListener(Retry);
                
            }

     }

//method scene changer
     public void Next()
     {
        SceneManager.LoadScene("PerfectScore");
     }
     
     public void Retry(){
        SceneManager.LoadScene("level_PiedasPlatas");
    }

    public void displayProficiency(){
        if(points == 1){
            proficient = "Beginner";
            Debug.Log("Beginner");
        }
        if(points == 2){
            proficient = "Beginner";
            Debug.Log("Beginner");
        }
        if(points == 3){
            proficient = "Intemediate";
            Debug.Log("Intermediate");
        }
        if(points == 4){
            proficient = "Intemediate";
            Debug.Log("Intermediate");
        }
        if(points == 5){
           proficient = "Advance";
           Debug.Log("Advance");
        }

    }

   
    
    
     


//right wrong method

    public void correct()
    {

            FlashPanel.SetActive(true);
            FlashText.text = "Tama ka!";
            points += 1;
            Answer = true;
            QnA.RemoveAt(currentQuestion);
            generateQuestion();
            displayProficiency();
    }

    public void wrong()
    {
            FlashPanel.SetActive(true);
            FlashText.text = "Mali ka!";
            Answer = true;
            QnA.RemoveAt(currentQuestion);
            generateQuestion();
            displayProficiency();
    }

//Answers
    void SetAnswers(){

        for (int i = 0; i < options.Length; i++) 
        {
            options[i].GetComponent<AnswerScript3>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = QnA[currentQuestion].Answer[i]; 

            if(QnA[currentQuestion].CorrectAnswer == i)
            {
                  options[i].GetComponent<AnswerScript3>().isCorrect = true;
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
