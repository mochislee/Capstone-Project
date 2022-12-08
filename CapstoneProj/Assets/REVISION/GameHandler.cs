using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {
    [SerializeField] PointCounter pointCounter;
    [SerializeField] HighscoreHandler highscoreHandler;
    [SerializeField] PointHUD pointHUD;
    [SerializeField] string playerName;

    public void StartGame () {
        pointCounter.StartGame ();
    }

}