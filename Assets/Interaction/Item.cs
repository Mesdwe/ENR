using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item",menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public enum InteractType:int
    {
        PickupItem,
        BagItem,
        SceneItem_Switch,
        SceneItem_Puzzle,
        SceneItem_zoom,
        Uninteractable
    }
    new public string name = "New Item";
    public Sprite icon = null;
    public string description;
    public InteractType interacttype = InteractType.Uninteractable;
}
