using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class quizHandler : MonoBehaviour
{
  
    public int q = 1;
    public QuizManager q1;
    public PlaytimeTimerScript playerTimer;
    [SerializeField] string filename;

    

    List<quizData> quizEntries = new List<quizData> ();
    public delegate void ListChanged (List<quizData> list);
    public static event ListChanged listChanged;


    private void Start () {
        quizEntries = FileHandler.ReadListFromJSON<quizData> (filename);

        if (listChanged != null) {
            listChanged.Invoke (quizEntries);
        }
    }

    
    public void AddToList () {
      
       quizEntries.Add(new quizData (q, q1.score, playerTimer.playtime, q1.proficient));

       FileHandler.SaveToJSON<quizData> (quizEntries, filename);
      if (listChanged != null) {
            listChanged.Invoke (quizEntries);
        }
    }



}
