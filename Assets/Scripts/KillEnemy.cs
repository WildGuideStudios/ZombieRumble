using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    void Update()
    {

    try {
            if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteraction();
        }

        catch (System.NullReferenceException)
        {
            Debug.Log ("Don't forget to add EventSystem object in hirarchy");
        }
    }

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;
            if(interactedObject.tag == "Zombie")
            {
                Debug.Log("Zombie Hit!");
            }
            else
            {
                Debug.Log("You Missed!");
            }
        }
    }
}