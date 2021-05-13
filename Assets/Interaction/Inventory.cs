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
        if (instance == null)
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
    public BagItem cur_item = null;

    public Transform iconList;
    public GameObject buttonPrefab;

    public void Add(Item item)
    {
        items.Add(item);
        GameObject bagItem = Instantiate(buttonPrefab, iconList);
        bagItem.transform.SetParent(iconList);
        bagItem.GetComponent<ButtonTest>().SetBagItem(item);
        //Debug.Log("There are " + Show(items) + "in your bag");
    }
    public void Remove(Item item)
    {
        items.Remove(item);
    }
    public string Show(List<Item> items)
    {
        StringBuilder str = new StringBuilder();
        foreach (Item item in items)
        {
            str.Append(item.name);
            str.Append(" ");
        }
        return str.ToString();
    }
}
