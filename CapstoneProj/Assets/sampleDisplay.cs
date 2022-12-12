using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;
using System;




public class sampleDisplay : MonoBehaviour
{

    public GameObject highscoreUIElementPrefab;
    public Transform elementWrapper;
    [SerializeField] GameObject panel;



    //public UnityEngine.UI.Text nameTxt;
    //public UnityEngine.UI.Text quizTxt;
    //public TextAsset jsonFile;
    //public TextAsset jsonFileQuiz;

    //string filename, filePath;
    //string mJson, jsonQuiz ;


/**

   public void start(){
        Debug.Log(JSONReader.GetJSON(jsonFile).playerName);
        //filename = jsonFile.text;
        }   

 void display(){
        System.Array.Sort(namesArray);
        foreach(string line in namesArray){
           nameTxt.text += line + "\n";
        }
    }
    public void read(){
        namesArray = File.ReadAllLines(filename);
        display();
    }
    public void showName(){
        mJson = jsonFile.text;
        jsonQuiz = jsonFileQuiz.text;
        //var jsonData = JsonConvert.DeserializeObject<dynamic>(mJson);
        
    

        //nameTxt.text = JSONReader.GetJSON(jsonFile).playerName;
        nameTxt.text = mJson;
        quizTxt.text = jsonQuiz;

        Debug.Log(mJson);
        Debug.Log(jsonQuiz); 
    } 
    
    }
    public static class JSONReader{
        public static InputEntry GetJSON(TextAsset jsonFile){
            InputEntry example = JsonUtility.FromJson<InputEntry>(jsonFile.text);
            return example;

        }
        */


    List<GameObject> uiElements = new List<GameObject> ();
  

    private void OnEnable () {
        InputHandler.onHighscoreListChanged += UpdateUI;
        
    }

    private void OnDisable () {
        InputHandler.onHighscoreListChanged -= UpdateUI;
    
    }

    public void ShowPanel () {
        panel.SetActive (true);
    }

    public void ClosePanel () {
        panel.SetActive (false);
    }

    private void UpdateUI (List<InputEntry> list) {
        for (int i = 0; i < list.Count; i++) {
            InputEntry el = list[i];

            if (el != null) {
                if (i >= uiElements.Count) {
                    // instantiate new entry
                    var inst = Instantiate (highscoreUIElementPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent (elementWrapper, false);

                    uiElements.Add (inst);
                }

                // write or overwrite name & points
                var texts = uiElements[i].GetComponentsInChildren<Text> ();
                texts[0].text = el.playerName;
                Debug.Log(el.playerName);
            }
        }
    }

 

    }


/**
/////
 List<GameObject> uiElements = new List<GameObject> ();

    private void OnEnable () {
        HighscoreHandler.onHighscoreListChanged += UpdateUI;
    }

    private void OnDisable () {
        HighscoreHandler.onHighscoreListChanged -= UpdateUI;
    }

    public void ShowPanel () {
        panel.SetActive (true);


    }

    public void ClosePanel () {
        panel.SetActive (false);
    }


    private void UpdateUI (List<InputEntry> list) {
        for (int i = 0; i < list.Count; i++) {
            InputEntry el = list[i];

            if (el != null) {
                if (i >= uiElements.Count) {

                    var inst = Instantiate (highscoreUIElementPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent (elementWrapper, false);

                    uiElements.Add (inst);
                }

                var texts = uiElements[i].GetComponentsInChildren<Text> ();
                texts[0].text = el.playerName;
                Debug.Log(texts);

            }
        }
    }
    **/


    

