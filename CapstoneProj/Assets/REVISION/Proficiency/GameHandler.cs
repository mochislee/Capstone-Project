using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    [SerializeField] public int score = 0;

    public void ResetPoints () {
        score = 0;
    }

    public void AddPoints ()
    {
        score += 1;
    }

}
