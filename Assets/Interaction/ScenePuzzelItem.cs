using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePuzzelItem : SceneItem
{
    public string NeededItemName = " ";
    protected override void OnInteract()
    {
        //if (GameObject.Find(NeededItemName).GetComponent<BagItem>().selected)
        if (GameObject.Find("Inventory").GetComponent<Inventory>().cur_item != null)
        {
            if (GameObject.Find("Inventory").GetComponent<Inventory>().cur_item.name == NeededItemName)
            {
                Debug.Log("Puzzle Solved");
                Destroy(gameObject);
                Destroy(GameObject.Find(NeededItemName));
            }
            else
            {
                Debug.Log("Wrong Item");
                Inventory.instance.cur_item = null;
            }
        }
    }
}
