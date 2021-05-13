using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : SceneItem
{
    public GameObject targetState;
    public GameObject oppositeState;
    public GameObject defaultState;
    protected override void OnInteract()
    {
        //player animation
        targetState.SetActive(true);
        oppositeState.SetActive(false);
        defaultState.SetActive(false);
        StartCoroutine(ResetNotes());
    }

    IEnumerator ResetNotes()
    {
        yield return new WaitForSeconds(1f);
        targetState.SetActive(false);
        if (!oppositeState.activeSelf)
        {
            oppositeState.SetActive(false);
            defaultState.SetActive(true);
        }

    }


}
