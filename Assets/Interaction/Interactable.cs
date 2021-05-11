using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private Material mat;
    [SerializeField] protected Item item;
    public void OnMouseEnter()
    {
        mat.SetInt("_Outline", 1);

    }
    public void OnMouseExit()
    {
        mat.SetInt("_Outline", 0);
    }

    protected void OnMouseDown()
    {
        Debug.Log(item.description);
    }
}
