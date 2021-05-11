using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovementController : MonoBehaviour
{
    [SerializeField] Transform[] camTransforms;
    [SerializeField] private GameObject cam;
    int position = 0;
    public void MoveRight()
    {
        if (position >= camTransforms.Length - 1)
        {
            return;
        }
        position++;
        Transform camTransform = camTransforms[position];
        //temp
        cam.transform.position = camTransform.position;
    }
    public void MoveLeft()
    {
        if (position <= 0)
        {
            return;
        }
        position--;
        Transform camTransform = camTransforms[position];
        //temp
        cam.transform.position = camTransform.position;
    }
}
