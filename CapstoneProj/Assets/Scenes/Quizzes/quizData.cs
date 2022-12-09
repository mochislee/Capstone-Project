using System;

[Serializable]
public class quizData {
    public int playerScore;
    public int playerTime;
    public string playerPoficiency;
    public int quizNo;
   
  
    public quizData (int no, int score, int timer, string prof) {
        quizNo = no;
        playerScore = score;
        playerTime = timer;
        playerPoficiency = prof;


    }
}