using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DoorKeyInteractor : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionPointRadius;
    [SerializeField] private LayerMask interactableMask;
    [SerializeField] private InteractionPromptUI interactionPromptUI;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] private int numFound;

    private DoorKeyIInteractable dkinteractable;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionPointRadius, colliders, interactableMask);

        if (numFound > 0)
        {
            dkinteractable = colliders[0].GetComponent<DoorKeyIInteractable>();

            if (dkinteractable != null)
            {
                if (!interactionPromptUI.isDisplayed) interactionPromptUI.Setup(dkinteractable.InteractionPrompt);

                if (Keyboard.current.fKey.wasPressedThisFrame) dkinteractable.DoorKeyInteract(this);
            }
        }

        else
        {
            if (dkinteractable != null) dkinteractable = null;

            if (interactionPromptUI.isDisplayed) interactionPromptUI.Close();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPointRadius);
    }
}
