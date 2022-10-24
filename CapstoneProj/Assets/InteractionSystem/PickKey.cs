using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class PickKey : MonoBehaviour, IInteractable
{
    public Input keyCode;
    public Component doorcolliderhere;
    public GameObject keygone;

    [SerializeField] private string prompt;
    public string InteractionPrompt => prompt;

    void OnTriggerStay(Collider key)
    {
        PickKey_Display pickKey = key.GetComponent<PickKey_Display>();

        if (pickKey != null)
        {
            pickKey.KeyCollected();
            if (Input.GetKey(KeyCode.F))
                keygone.SetActive(false);
        }   
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
