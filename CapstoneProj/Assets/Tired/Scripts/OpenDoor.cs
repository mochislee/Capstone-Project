using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animation hingehere;

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.F))
            hingehere.Play();
        
    }
}
