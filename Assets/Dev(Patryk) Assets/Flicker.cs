using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Flicker : MonoBehaviour
{
    GameObject background;
    Image backgroundAlpha;
    private IEnumerator coroutine;

    void Start()
    {
        background = GameObject.Find("BackgroundScreen");
        backgroundAlpha = background.GetComponent<Image>();
    }



    void Update()
    {

    }

    private IEnumerator flicker(float randomtime)
    {
        yield return new WaitForSeconds(randomtime);
    }

    void flickeron()
    {

    }
    void flickeroff()
    {

    }
}
