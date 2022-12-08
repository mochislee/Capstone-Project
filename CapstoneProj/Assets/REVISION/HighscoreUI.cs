using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreUI : MonoBehaviour {
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panel1;
    [SerializeField] GameObject highscoreUIElementPrefab;
    [SerializeField] Transform elementWrapper;

    List<GameObject> uiElements = new List<GameObject> ();

    private void OnEnable () {
        HighscoreHandler.onHighscoreListChanged += UpdateUI;
    }

    private void OnDisable () {
        HighscoreHandler.onHighscoreListChanged -= UpdateUI;
    }

    public void ShowPanel () {
        panel.SetActive (true);
        panel1.SetActive (false);

    }

    public void ClosePanel () {
        panel.SetActive (false);
        panel1.SetActive (true);
    }

    private void UpdateUI (List<HighscoreElement> list) {
        for (int i = 0; i < list.Count; i++) {
            HighscoreElement el = list[i];

            if (el != null && el.points > 0) {
                if (i >= uiElements.Count) {

                    var inst = Instantiate (highscoreUIElementPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent (elementWrapper, false);

                    uiElements.Add (inst);
                }

                var texts = uiElements[i].GetComponentsInChildren<Text> ();
                texts[0].text = el.playerName;
                texts[1].text = el.points.ToString ();
                texts[2].text = el.timer;
            }
        }
    }

}