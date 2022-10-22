using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animation hingehere;

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.F))
            hingehere.Play();
    }

}
