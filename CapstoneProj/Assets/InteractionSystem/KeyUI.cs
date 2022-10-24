using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyUI : MonoBehaviour
{
    private TextMeshProUGUI keyText;

    void Start()
    {
        keyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatekeyText(PickKey_Display keydisplay)
    {
        keyText.text = keydisplay.NumberOfKey.ToString();
    }
}
