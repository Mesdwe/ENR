using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]private Material mat;

    private void OnMouseEnter()
    {
        mat.SetInt("_Outline",1);
    }
    private void OnMouseExit() {
        mat.SetInt("_Outline",0);
    }
//test
//testForBranch
//testBranch
}
