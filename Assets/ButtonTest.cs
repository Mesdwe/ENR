using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonTest : MonoBehaviour
{
    public Item item;
    public void SetBagItem(Item itemT)
    {
        item = itemT;
        this.GetComponent<Image>().sprite = item.icon;
        this.name = item.name;
        
    }
    public void OnSelected()
    {
        Inventory.instance.cur_item = item;
        
    }
}
