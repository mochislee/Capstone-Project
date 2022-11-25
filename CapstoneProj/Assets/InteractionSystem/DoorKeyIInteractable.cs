using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface DoorKeyIInteractable
{
    public string InteractionPrompt { get; }

    public bool DoorKeyInteract(DoorKeyInteractor interactor);

}
