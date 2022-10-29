using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickKey : MonoBehaviour, IInteractable
{
    [SerializeField] public Component doorcolliderhere;
    [SerializeField] public GameObject keygone;

    [SerializeField] private string prompt;
    public string InteractionPrompt => prompt;

    void OnTriggerStay()
    {
            if (Input.GetKey(KeyCode.F))
                doorcolliderhere.GetComponent<BoxCollider>().enabled = true;

            if (Input.GetKey(KeyCode.F))
                keygone.SetActive(false);
    }

    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null) return false;

        if (inventory.HasKey)
        {
            Debug.Log("Collecting key.");
            return true;
        }
        Debug.Log("No key found!");
        return false;
    }
}
