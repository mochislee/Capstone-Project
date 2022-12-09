using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {
    [SerializeField] public InputField nameInput;
    private QuizManager q1;
    private PlaytimeTimerScript playerTimer;
    [SerializeField] string filename;

    

    List<InputEntry> entries = new List<InputEntry> ();

    private void Start () {
        entries = FileHandler.ReadListFromJSON<InputEntry> (filename);
    }

    public void AddNameToList () {
       entries.Add(new InputEntry (nameInput.text));
       nameInput.text = "";

       FileHandler.SaveToJSON<InputEntry> (entries, filename);
    }
}