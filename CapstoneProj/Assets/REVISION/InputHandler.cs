using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {
    [SerializeField] public InputField nameInput;
    [SerializeField] string filename;
    [SerializeField] public GameObject panel;
    [SerializeField] PointHUD pointHUD;
    [SerializeField] PointCounter pointCounter;
    [SerializeField] HighscoreHandler highscoreHandler;
    [SerializeField] Text timer;


    List<InputEntry> entries = new List<InputEntry> ();

    private void Start () {
        entries = FileHandler.ReadListFromJSON<InputEntry> (filename);
    }

    public void AddNameToList () {
        highscoreHandler.AddHighscoreIfPossible (new HighscoreElement (nameInput.text, pointHUD.Points, timer.text));
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}