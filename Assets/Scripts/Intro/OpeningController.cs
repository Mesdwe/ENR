using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class OpeningController: MonoBehaviour
{
    private int aa=0;
    public Animator ani;
    public float timer;
    private bool ready =true;

    public void add(){
        if(!ready) return;
        aa++;
        ani.SetInteger("i",aa);
        if(aa>4){
            SceneManager.LoadScene(1);
        }
        StartCoroutine(CoolDown());
    }
    IEnumerator CoolDown()
    {
        ready = false;
        yield return new WaitForSeconds(1f);
        ready = true;
    }
}
