using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Light : SceneItem
{
    //:KeyItem
    protected override void OnInteract()
    {
        //wait perhaps
        //jump
        SceneManager.LoadScene(2);
        
    }
}
