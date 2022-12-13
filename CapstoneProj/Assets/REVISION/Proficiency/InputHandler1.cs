using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler1 : MonoBehaviour {
    [SerializeField] InputField nameInput;
    [SerializeField] string filename;
    [SerializeField] QuizManager quiz;
    [SerializeField] HighscoreHandler highscoreHandler;

    public GameObject panel;
    public GameObject panel1;


    List<InputEntry> entries = new List<InputEntry> ();

    private void Start () {
        entries = FileHandler.ReadListFromJSON<InputEntry> (filename);
        
    }

    public void AddNameToList () {
        highscoreHandler.AddHighscoreIfPossible (new HighscoreElement (nameInput.text, quiz.points, quiz.proficient));

    }

    public void NameAdd()
    {
        panel.SetActive(false);
        panel1.SetActive(true);

    }



    
}