using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneItem : Interactable
{
    [SerializeField] private Transform camTransform;
    [SerializeField] private float camZoomedSize;
    [SerializeField] private GameObject zoomedObject;
    public bool zoom;
    protected override void OnInteract()
    {
        base.OnInteract();
        ZoomIn();

        Debug.Log("Do something");
    }
    private void ZoomIn()
    {
        //Camera zoom in
        if (zoom)
            MovementController.instance.ZoomIn(camZoomedSize, camTransform);
        //temp
        //zoomedObject.SetActive(true);
        //gameObject.SetActive(false);
    }


}
