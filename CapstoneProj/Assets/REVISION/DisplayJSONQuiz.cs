using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayJSONQuiz : MonoBehaviour
{

    public TextAsset jsonQuizData;

    void Start()
    {
        Debug.Log(JSONReaderQuiz.GetJsonQuiz(jsonQuizData).playerScore);
        Debug.Log(JSONReaderQuiz.GetJsonQuiz(jsonQuizData).playerProficiency);
    }
}

public static class JSONReaderQuiz
{
    public static PlayerScore GetJsonQuiz(TextAsset jsonQuizData)
    {
        PlayerScore scoreData = JsonUtility.FromJson<PlayerScore>(jsonQuizData.text);
            return scoreData;



    }

}

[System.Serializable]
public class PlayerScore
{
    public int playerScore;
    public string playerProficiency;
}
