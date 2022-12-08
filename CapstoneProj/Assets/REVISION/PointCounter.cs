using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour {
    [SerializeField] PointHUD pointHUD;
    bool gameStopped = false;

    public void StartGame () {

        pointHUD.ResetPoints ();

    }

      public void AddPoints ()
    {
        pointHUD.Points += 5;
    }

}