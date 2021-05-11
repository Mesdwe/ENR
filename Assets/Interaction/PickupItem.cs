using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : Interactable
{
    new protected void OnMouseDown()
    {
        base.OnMouseDown();
        Destroy(gameObject);
    }
}
