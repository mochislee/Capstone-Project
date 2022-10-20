using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance;

    public TMPro.TextMeshProUGUI interactionText;

    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, interactionDistance))
        {
            //Interactable interactable = hit.
        }
    }
}
