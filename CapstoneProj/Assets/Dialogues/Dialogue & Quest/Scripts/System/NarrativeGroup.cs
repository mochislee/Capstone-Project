using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueQuests
{
    /// <summary>
    /// Groups prevent 2 NarrativeEvent from triggering at the same time, if they are in the same group. 
    /// Group conditions are also applied to all NarrativeEvent inside the group.
    /// Lowest priority will trigger first (if many of the same trigger have valid conditions)
    /// Priority is determined based on the object hierarchy, first one has priority
    /// </summary>

    public class NarrativeGroup : MonoBehaviour
    {
        private int priority;

        void Awake()
        {
            priority = transform.GetSiblingIndex(); //First one has priority over other ones

            foreach (NarrativeEvent evt in GetComponentsInChildren<NarrativeEvent>())
            {
                evt.AddConditions(GetComponents<NarrativeCondition>());
            }
        }

        public int GetPriority()
        {
            return priority;
        }
    }

}
