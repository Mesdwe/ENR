using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovementController : MonoBehaviour
{
    public static MovementController instance;
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    public delegate void OnCameraSizeChanged();
    public OnCameraSizeChanged onZoomed;
    [SerializeField] Transform[] camTransforms;
    [SerializeField] private int camDefaultSize;
    [SerializeField] GameObject switchRoom;
    [SerializeField] GameObject zoomOut;
    private Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    int position = 0;
    public void MoveRight()
    {
        position++;
        if (position >= camTransforms.Length)
            position = 0;
        MoveCamera();
    }
    public void MoveLeft()
    {
        position--;
        if (position < 0)
            position = camTransforms.Length - 1;
        MoveCamera();
    }

    public void ZoomIn(float camerSize, Transform target)
    {
        cam.orthographicSize = camerSize;
        cam.transform.position = target.position;

        if (onZoomed != null)
            onZoomed.Invoke();
        SwitchMode(true);
    }
    public void ZoomOut()
    {
        cam.orthographicSize = camDefaultSize;
        if (onZoomed != null)
            onZoomed.Invoke();
        MoveCamera();
        SwitchMode(false);
    }

    public void SwitchMode(bool zoomed)
    {
        switchRoom.SetActive(!zoomed);
        zoomOut.SetActive(zoomed);
    }
    private void MoveCamera()
    {
        Transform camTransform = camTransforms[position];
        //temp
        cam.transform.position = camTransform.position;
    }
}
