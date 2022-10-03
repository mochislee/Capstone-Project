using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Callbacks;

namespace First.Dialogue.Editor
{
    public class DialogueEditor : EditorWindow
    {
        Dialogue selectedDialogue = null;
        

        // Para magkaroon ng option sa Window
        [MenuItem("Window/Dialogue Editor")]
        public static void showEditorWindow()
        {
            GetWindow(typeof(DialogueEditor), false, "Dialogue Editor");
        }

        [OnOpenAssetAttribute(1)]
        public static bool OnOpenAsset(int instanceID, int line)
        {
            Dialogue dialogue = EditorUtility.InstanceIDToObject(instanceID) as Dialogue;
            if (dialogue != null) {
                showEditorWindow();
                return true;
            }
            
            return false;
        }

        private void OnEnable() 
        {
            Selection.selectionChanged += OnSelectionChanged;
        }

        // Updates the selected dialogue in Dialogue Editor
        private void OnSelectionChanged() {
            Dialogue newDialogue = Selection.activeObject as Dialogue;
            if (newDialogue != null)
            {
                selectedDialogue = newDialogue;
                Repaint();
            }
        }

        private void OnGUI() {
            if (selectedDialogue == null) {
                EditorGUILayout.LabelField("No Dialogue Selected.");
            }
            else {
                
                foreach (DialogueNode node in selectedDialogue.GetAllNodes()) {
                    EditorGUI.BeginChangeCheck();

                    EditorGUILayout.LabelField("Node:");
                    string newText = EditorGUILayout.TextField(node.text);
                    string newUniqueID = EditorGUILayout.TextField(node.uniqueID);

                    if (EditorGUI.EndChangeCheck()) {
                        Undo.RecordObject(selectedDialogue, "Update Dialogue Text");
                        node.text = newText;
                    }
                    
                }
            }

            
            
        }
    }
}
