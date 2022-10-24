using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickKey_Display : MonoBehaviour
{
    public int NumberOfKey { get; private set; }

    public UnityEvent<PickKey_Display> OnKeyCollected;

    public void KeyCollected()
    {
        for(int i = 0; i < NumberOfKey; i++)
        {
            NumberOfKey++;
            OnKeyCollected.Invoke(this);
        }
    }
}
