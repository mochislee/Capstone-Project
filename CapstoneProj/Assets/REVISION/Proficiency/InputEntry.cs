using System;

[Serializable]
public class InputEntry {
    public string playerName;
    public int score;

    public InputEntry (string name, int score) {
        playerName = name;
        this.score = score;
    }
}
