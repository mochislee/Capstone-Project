using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bato_Cutscene : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Bato");

    }
}
