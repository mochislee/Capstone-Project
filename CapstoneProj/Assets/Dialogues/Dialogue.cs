using System;
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

        Dictionary<string, DialogueNode> nodeLookup = new Dictionary<string, DialogueNode>();

        private void OnValidate() {
            nodeLookup.Clear();
            foreach (DialogueNode node in GetAllNodes())
            {
                nodeLookup[node.uniqueID] = node;
            }
        }

        private void Awake() {
            if (nodes.Count == 0)
            {
                nodes.Add(new DialogueNode());
            }
        }

        // Only included if running the editor
#if UNITY_EDITOR
        
#endif
        

        public IEnumerable<DialogueNode> GetAllNodes() {
            return nodes;
        }

        public DialogueNode GetRootNode(){
            return nodes[0];
        }

        public IEnumerable<DialogueNode> GetAllChildren(DialogueNode parentNode) {
            List<DialogueNode> result = new List<DialogueNode>();
            foreach (string childID in parentNode.children) {    
                if( nodeLookup.ContainsKey(childID)){
                    yield return nodeLookup[childID];
                }
                
            }
        }
        
    }
}