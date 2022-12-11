using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayJSONName : MonoBehaviour
{

    public TextAsset jsonNameData;

    void Start()
    {
        Debug.Log(JSONReaderName.GetJsonName(jsonNameData).playerName);
    }

    public static class JSONReaderName
    {
        public static PlayerName GetJsonName(TextAsset jsonNameData)
        {
            PlayerName nameData = JsonUtility.FromJson<PlayerName>(jsonNameData.text);
            return nameData;
        }
    }

    [System.Serializable]
    public class PlayerName
    {
        public string playerName;
    }
}


