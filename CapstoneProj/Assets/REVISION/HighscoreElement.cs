using System;

[Serializable]
public class HighscoreElement {
    public string playerName;
    public int points;
    public string timer;


    public HighscoreElement (string name, int points, string timers) {
        playerName = name;
        this.points = points;
        timer = timers;
    }

}