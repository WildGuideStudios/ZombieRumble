using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillEnemy : MonoBehaviour
{
    public int points = 1;

    void Update()
    {

        try
        {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
                GetInteraction();
        }

        catch (System.NullReferenceException)
        {
            Debug.Log("Don't forget to add EventSystem object in hirarchy");
        }
    }

    public void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;

            if (interactedObject.tag == "Zombie")
            {
                Destroy(interactedObject);
            }
            else
            {
                Debug.Log("You Missed!");
            }
        }
    }

    private void OnDestroy()
    {
        PointCounter.points += points;
    }
}