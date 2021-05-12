using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagItem : Interactable
{
    public bool selected = false;
    protected override void OnInteract()
    {
        selected = !selected;
        Debug.Log("Now it is " + selected + " selected");
    }
}
