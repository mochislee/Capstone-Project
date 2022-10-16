using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickBread : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other){
        
        PickBread_Display breaddisplay = other.GetComponent<PickBread_Display>();

        if(breaddisplay != null){
            breaddisplay.BreadCollected();
            gameObject.SetActive(false);
        }
        
    }


}
