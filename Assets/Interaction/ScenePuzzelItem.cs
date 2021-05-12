using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePuzzelItem : SceneItem
{
    public string NeededItemName = " ";
    protected override void OnInteract()
    {
        if (GameObject.Find(NeededItemName).GetComponent<BagItem>().selected)
        {
            Debug.Log("Puzzle Solved");
            Destroy(gameObject);
            Destroy(GameObject.Find(NeededItemName));
        }
        else
        {
            Debug.Log("Wrong Item");
        }
    }
}
