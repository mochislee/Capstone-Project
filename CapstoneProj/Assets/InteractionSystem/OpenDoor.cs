using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour, IInteractable
{
    public Animation hingehere;

    [SerializeField] private string prompt;
    public string InteractionPrompt => prompt;

    
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.F))
            hingehere.Play();
    }
    
    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null) return false;

        if (inventory.HasKey)
        {
            if (Input.GetKey(KeyCode.F))
                hingehere.Play();
        }
        Debug.Log("No key found!");
        return false;
    }
}
