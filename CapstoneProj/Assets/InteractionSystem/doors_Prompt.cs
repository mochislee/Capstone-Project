using System.Security.AccessControl;
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            UnityEngine.Debug.Log(message: "Press [F] to Open door!");
            return true;
        }

        UnityEngine.Debug.Log(message: "No key found!");
        return false;
    }
}
