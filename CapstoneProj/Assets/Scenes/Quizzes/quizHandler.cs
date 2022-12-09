using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizHandler : MonoBehaviour
{
   
    public QuizManager q1;
    public PlaytimeTimerScript playerTimer;
    [SerializeField] string filename;

    

    List<quizData> quizEntries = new List<quizData> ();

    private void Start () {
        quizEntries = FileHandler.ReadListFromJSON<quizData> (filename);
    }

    public void AddToList () {
       quizEntries.Add(new quizData (q1.score, playerTimer.playtime));
       

       FileHandler.SaveToJSON<quizData> (quizEntries, filename);
    }
}
