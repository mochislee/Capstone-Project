using System.Security.AccessControl;
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class doors_Prompt : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;

    public string InteractionPrompt => prompt;

    public bool Interact(Interactor interactor)
    {
        
        var inventory = interactor.GetComponent<Inventory>();

        if(inventory == null) return false;

        if (inventory.HasKey)
        {
            Debug.Log("Opening door.");
            return true;
        }

        Debug.Log("No key found!");
        return false;
    }
}
