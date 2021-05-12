using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : Interactable
{
    protected override void OnInteract()
    {
        Debug.Log("Picked up the " + item.name);
        Debug.Log("This item is " + item.description);
        Inventory.instance.Add(item);
        Destroy(gameObject);
    }
}
