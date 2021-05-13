using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTalk : SceneItem
{
    public GameObject subtitle;
    protected override void OnInteract()
    {
        subtitle.SetActive(true);
        StartCoroutine(Disapear());
    }
    
    IEnumerator Disapear()
    {
        yield return new WaitForSeconds(2f);
        subtitle.SetActive(false);
    }
}
