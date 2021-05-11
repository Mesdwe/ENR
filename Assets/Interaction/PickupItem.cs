using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : Interactable
{
    new protected void OnMouseDown()
    {
        bool pickable = base.OnMouseDown();
        if(pickable)
        {
            Debug.Log("Picked up the " + item.name);
            Debug.Log("This item is " + item.description);
            Inventory.instance.Add(item);
            Destroy(gameObject);
        }

    }
}
