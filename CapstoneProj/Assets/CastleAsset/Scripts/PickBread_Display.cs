using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickBread_Display : MonoBehaviour
{

    public int NumberOfBread { get; private set; }

    public UnityEvent<PickBread_Display> OnBreadCollected;
    
    public void BreadCollected(){
        NumberOfBread++;
        OnBreadCollected.Invoke(this);
    }
}
