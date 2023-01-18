using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Flicker : MonoBehaviour
{
    GameObject background;
    private Image backgroundAlpha;
    private IEnumerator coroutine;
    private float randomeness;
    private GameObject audiopart;
    private AudioSource Audio;

    void Start()
    {
        background = GameObject.Find("BackgroundScreen");
        backgroundAlpha = background.GetComponent<Image>();
        coroutine = flicker();
        audiopart = GameObject.Find("AudioSource");
        Audio = audiopart.GetComponent<AudioSource>();
        StartCoroutine(coroutine);
    }



    void Update()
    {

    }

    private IEnumerator flicker()
    {
        while (true)
        {
            randomeness = Random.Range(0.05f, 5f);
            yield return new WaitForSeconds(randomeness);
            flickeron();
            yield return new WaitForSeconds(0.1f);
            flickeroff();
            Audio.Play();
        }
    }

    void flickeron()
    {
        backgroundAlpha.DOFade(0, 0.0f);
    }
    void flickeroff()
    {
        backgroundAlpha.DOFade(1, 0.0f);
    }
}
