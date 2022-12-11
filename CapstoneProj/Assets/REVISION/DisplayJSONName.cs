using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayJSONName : MonoBehaviour
{
    public InputEntry player;
    public TextAsset jsonNameData;

    void Start()
    {
        Debug.Log(JSONReaderName.GetJsonName(jsonNameData).playerName);
    }

    public static class JSONReaderName
    {
        public static InputEntry GetJsonName(TextAsset jsonNameData)
        {
            InputEntry nameData = JsonUtility.FromJson<InputEntry>(jsonNameData.text);
            return nameData;
        }
    }

    
}


