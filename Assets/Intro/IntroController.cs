using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    public GameObject introA;
    public GameObject introB;
    public GameObject switchRoomButton;
    public void AfterShadow()
    {
        introA.SetActive(false);
        introB.SetActive(true);
        switchRoomButton.SetActive(false);
    }
}
