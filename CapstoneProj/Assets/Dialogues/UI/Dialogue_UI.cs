using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using First.Dialogue;
using TMPro;

namespace First.UI
{
    public class Dialogue_UI : MonoBehaviour
    {
        PlayerConversant playerConversant;
        [SerializeField] TextMeshProUGUI AIText;

        // Start is called before the first frame update
        void Start()
        {
            playerConversant = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerConversant>();
            AIText.text = playerConversant.GetText();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
