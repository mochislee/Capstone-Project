using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace First.Dialogue
{
    // Para magkaroon ng option sa Project na tab
    [CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogues", order = 0)]
    public class Dialogue : ScriptableObject
    {
        [SerializeField]
        DialogueNode[] nodes;
    }
}