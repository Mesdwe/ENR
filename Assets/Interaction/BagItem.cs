using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagItem : Interactable
{
    public Inventory manager;

    //manager=GameObject.Find("Inventory").GetComponent<Inventory>();

    protected override void OnInteract()
    {
        //Inventory.instance.cur_item = this;
        //manager.cur_item=this;
        Debug.Log("Now selected the " + Inventory.instance.cur_item.name);
    }
}
