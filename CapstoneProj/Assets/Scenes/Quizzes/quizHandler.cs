using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizHandler : MonoBehaviour
{
    public int q = 1;
    public QuizManager q1;
    public PlaytimeTimerScript playerTimer;
    [SerializeField] string filename;

    

    List<quizData> quizEntries = new List<quizData> ();

    private void Start () {
        quizEntries = FileHandler.ReadListFromJSON<quizData> (filename);
    }

    
    public void AddToList () {
      
       quizEntries.Add(new quizData (q, q1.score, playerTimer.playtime, q1.proficient));

       
       FileHandler.SaveToJSON<quizData> (quizEntries, filename);
    }
}
