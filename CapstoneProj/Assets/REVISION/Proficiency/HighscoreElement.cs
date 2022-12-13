using System;

[Serializable]
public class HighscoreElement {
    public string playerName;
    public int points;
    public string playerGrade;


    public HighscoreElement (string name, int points, string grade) {
        playerName = name;
        this.points = points;
        playerGrade = grade;
    }

}