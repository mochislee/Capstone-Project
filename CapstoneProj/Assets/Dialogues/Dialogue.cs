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
        List<DialogueNode> nodes = new List<DialogueNode>();

        Dictionary<string, DialogueNode> nodeLookup = new Dictionary<string, DialogueNode>();

        private void OnValidate() {
            nodeLookup.Clear();
            foreach (DialogueNode node in GetAllNodes()) {
                nodeLookup[node.uniqueID] = node;
            }
        }

        private void Awake() {
            if (nodes.Count == 0)
            {
                DialogueNode rootNode = new DialogueNode();
                rootNode.uniqueID = Guid.NewGuid().ToString();
                nodes.Add(rootNode);
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
            foreach (string childID in parentNode.children) {    
                if( nodeLookup.ContainsKey(childID)){
                    yield return nodeLookup[childID];
                }
                
            }
        }
        // CREATE NODE
        public void CreateNode(DialogueNode parent) {
            DialogueNode newNode = new DialogueNode();
            newNode.uniqueID = Guid.NewGuid().ToString();
            parent.children.Add(newNode.uniqueID);
            nodes.Add(newNode);
            OnValidate();
        }
        // DELETE NODE
        public void DeleteNode(DialogueNode nodeToDelete) {
            nodes.Remove(nodeToDelete);
            OnValidate();
            CleanDanglingChildren(nodeToDelete);
        }
        // CLEAN DANGLING CHILDREN
        private void CleanDanglingChildren(DialogueNode nodeToDelete) {
            foreach (DialogueNode node in GetAllNodes()) {
                node.children.Remove(nodeToDelete.uniqueID);
            }
        }

    }
}