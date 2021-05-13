using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private Material mat;
    [SerializeField] protected Item item;

    void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
    }
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
        OnInteract();
    }

    protected virtual void OnInteract()
    {
        Debug.Log(item.description);
    }
}
