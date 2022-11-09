using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenChanger : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
}
