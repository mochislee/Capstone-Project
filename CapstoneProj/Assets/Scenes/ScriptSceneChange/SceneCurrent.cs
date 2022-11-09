using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCurrent : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }
    
    public void PlayGame(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

   }
}
