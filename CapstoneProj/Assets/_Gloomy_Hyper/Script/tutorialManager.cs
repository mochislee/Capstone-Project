using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public float wait = 2f;

    void Update(){
        for(int i = 0; i<popUps.Length; i++){
            if(i == popUpIndex){
                popUps[i].SetActive(true);
            }
            else{
                popUps[i].SetActive(false);
            }
        }
        if(popUpIndex == 0){
            if(Input.GetKey(KeyCode.D)){
                popUpIndex++;
                
            }
        }
        else if(popUpIndex == 1){
            if(Input.GetKey(KeyCode.A)){
                popUpIndex++;
                wait -= Time.deltaTime;
            }
        }    
        else if(popUpIndex == 2){
            if(Input.GetKey(KeyCode.S)){
                popUpIndex++;
                wait -= Time.deltaTime;
            }
        }   
        else if(popUpIndex == 3){
            if(Input.GetKey(KeyCode.W)){
                popUpIndex++;
                wait -= Time.deltaTime;
            }
        }
        else if(popUpIndex == 4){
            if(Input.GetKey(KeyCode.Space)){
                popUpIndex++;
                wait -= Time.deltaTime;
            }
        }
        else if(popUpIndex == 5){
            if(Input.GetKey(KeyCode.LeftShift)){
                popUpIndex++;
                wait -= Time.deltaTime;
            }
        }  
             
    } 
}
