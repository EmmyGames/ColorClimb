using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentObject = null;

    private void Update()
    {
        if (Input.GetButtonDown("Interact") && currentObject)
        {
            currentObject.SendMessage("DoInteraction");

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Substring(0, 8) == "Interact")// collision.gameObject.tag.Substring(12) == "Interactable"
        {
            currentObject = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(currentObject == collision.gameObject)
            currentObject = null;
    }
    
}
