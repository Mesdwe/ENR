using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class OpeningController : MonoBehaviour
{
    private int aa = 0;
    public Animator ani;
    public bool ready = true;

    public void add()
    {
        if (!ready) return;
        aa++;
        ani.SetInteger("i", aa);
        StartCoroutine(CoolDown());
    }
    IEnumerator CoolDown()
    {
        ready = false;
        yield return new WaitForSeconds(2f);
        ready = true;
    }

    public void AnimationTest()
    {
        SceneManager.LoadScene(1);
    }
}
