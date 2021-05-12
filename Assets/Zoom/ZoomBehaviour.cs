using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject defaultObject;
    [SerializeField] private GameObject zoomedObject;

    public void ZoomIn()
    {
        zoomedObject.SetActive(true);
        defaultObject.SetActive(false);
    }
    public void ZoomOut()
    {
        zoomedObject.SetActive(false);
        defaultObject.SetActive(true);
    }
}
