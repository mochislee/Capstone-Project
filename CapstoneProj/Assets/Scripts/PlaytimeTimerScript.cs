using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaytimeTimerScript : MonoBehaviour
{
    
    public int playtime;    // to manipulate time
    /*** FOR PLAYTIME ***/
    public int seconds;
    public int minutes;
    public int hours;

    /*** FOR VIEWING PLAYTIME ***/
    [SerializeField] private bool isVisible = true;

    GUIStyle changeFont = new GUIStyle();

    void Start()
    {
        playtime = totalPlaytiime.totalPlayTime;    // set time from the total
        StartCoroutine("Playtimer");

        changeFont.fontSize = 20;   // Font size
    }
    
    /*** PLAYTIMER ***/
    private IEnumerator Playtimer() {
        while (true) {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = (playtime % 60);
            minutes = (playtime / 60) % 60;
            hours = (playtime / 3600) % 24;

            totalPlaytiime.totalPlayTime = playtime;

            //Format("{00:00:00}", hours, minute,seconds);     // updates the total time
        }
    }

    /*** ONGUI ***/
    void OnGUI() {
        GUI.Label(new Rect(50, 50, 400, 50), 
            "Playtime = " +
            hours.ToString() + " Hours " +
            minutes.ToString() + " Minutes " +
            seconds.ToString() + " Seconds ",
            changeFont);
    }
}
