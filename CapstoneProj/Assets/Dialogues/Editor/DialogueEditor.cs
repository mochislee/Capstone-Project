using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Callbacks;

namespace First.Dialogue.Editor
{
    public class DialogueEditor : EditorWindow
    {
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
    }
}
