using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Before_Bato : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    public void PlayGame(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

   }
}
