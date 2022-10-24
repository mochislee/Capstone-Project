using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class PickBread : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;

    public string InteractionPrompt => prompt;

    public GameObject breadsgone;

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.F))
            breadsgone.SetActive(false);
    }

    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null) return false;

        if (inventory.HasBread)
        {
            Debug.Log("Collecting bread.");
            return true;
        }
        Debug.Log("No bread found!");
        return false;

    }


}
