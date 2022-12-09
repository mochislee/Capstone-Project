using System;

[Serializable]
public class quizData {
    public int playerScore;
    public int playerTime;
   
  
    public quizData (int score, int timer) {
        playerScore = score;
        playerTime = timer;
        

    }
}