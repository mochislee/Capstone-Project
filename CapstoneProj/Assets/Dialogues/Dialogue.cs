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
        List<DialogueNode> nodes;

        // Only included if running the editor
#if UNITY_EDITOR
        private void Awake() {
            if (nodes.Count == 0)
            {
                nodes.Add(new DialogueNode());
            }
        }
#endif
        public IEnumerable<DialogueNode> GetAllNodes() {
            return nodes;
        }
    }
}