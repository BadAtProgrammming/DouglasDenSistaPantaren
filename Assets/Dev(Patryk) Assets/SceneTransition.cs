using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class SceneTransition : MonoBehaviour
{
    //Reference everything -Dev
    private Tween fadeteween;
    GameObject panelobj;
    Image panelimage;
    private IEnumerator coroutine;
    private IEnumerator coroutine2;


    void Start()
    {
        panelobj = GameObject.Find("Transition");
        panelimage = panelobj.GetComponent<Image>();
        coroutine = FadeTransitionin(5.0f);

        coroutine2 = FadeTransitionout(5.0f);
        StartCoroutine(coroutine);
    }


    void Update()
    {

    }

    public IEnumerator FadeTransitionin(float waittime)
    {
        fadetranssitionin1();
        yield return new WaitForSeconds(3);
        panelobj.SetActive(false);
    }

    public IEnumerator FadeTransitionout(float waittime)
    {
        panelobj.SetActive(true);
        fadetransitionout1();
        yield return new WaitForSeconds(1);
    }

    //The fade voids:
    public void fadetransitionout1()
    {
        panelimage.DOFade(1, 3f);
    }
    public void fadetranssitionin1()
    {
        panelimage.DOFade(0, 3f);
    }
}
