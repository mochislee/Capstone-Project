using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;
using System;


public class quizDisplay : MonoBehaviour

{
    
    public GameObject quiz;
    public Transform element;
    

    List<GameObject> uiElements = new List<GameObject> ();
  

    private void OnEnable () {
        quizHandler.listChanged += UpdateUIQ;
        
    }

    private void OnDisable () {
        quizHandler.listChanged -= UpdateUIQ;
    
    }



    private void UpdateUIQ (List<quizData> list) {
        for (int i = 0; i < list.Count; i++) {
            quizData el = list[i];

            if (el != null) {
                if (i >= uiElements.Count) {
                    // instantiate new entry
                    var inst = Instantiate (quiz, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent (element, false);
                    uiElements.Add (inst);
                }
                // write or overwrite name & points
                var texts = uiElements[i].GetComponentsInChildren<Text> ();
                texts[0].text = el.playerScore.ToString();
                texts[1].text = el.playerTime.ToString();
                texts[2].text = el.playerProficiency;

                Debug.Log(el.playerScore);
                Debug.Log(el.playerTime);
                Debug.Log(el.playerProficiency);


            }
        }
    }
}
