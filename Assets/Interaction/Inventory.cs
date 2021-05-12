using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton Pattern
    public static Inventory instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            //keep gameobjects when changing scenes
        }
        else
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            Destroy(gameObject);
            //if exist a gameObject, then destory current gameObject
        }
    }
    #endregion

    public List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        if(item.pickable == true)
        {
            items.Add(item);
        }
        Debug.Log("There are " + Show(items) + "in your bag");
    }
    public void Remove (Item item)
    {
        items.Remove(item);
    }
    public string Show (List<Item> items)
    {
        StringBuilder str = new StringBuilder();
        foreach(Item item in items)
        {
            str.Append(item.name);
            str.Append(" ");
        }
        return str.ToString();
    }
}
