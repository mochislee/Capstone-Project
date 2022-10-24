using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BreadUI : MonoBehaviour
{
    private TextMeshProUGUI breadText;
    
    void Start()
    {
        breadText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBreadText(PickBread_Display breaddisplay){
        breadText.text = breaddisplay.NumberOfBread.ToString();
    }
}
