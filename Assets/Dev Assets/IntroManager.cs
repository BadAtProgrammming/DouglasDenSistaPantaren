using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    //Set the basic stuff for the intro to work omg no way? -Dev

    GameObject UnityLogo;
    GameObject AsepriteLogo;
    GameObject IntroCanvas;
    private Image imagetest;
    private Image asepriteimg;
    private IEnumerator coroutine;

    [SerializeField] private CanvasGroup canvasGroup;
    private Tween fadeTween;



    void Start()
    {
        //Reference the logos :skull: -Dev
        UnityLogo = GameObject.Find("UnityImage");
        AsepriteLogo = GameObject.Find("AsepriteImage");
        IntroCanvas = GameObject.Find("IntroCanvas");
        imagetest = UnityLogo.GetComponent<Image>();
        asepriteimg = AsepriteLogo.GetComponent<Image>();
        coroutine = Fadeit(5.0f);
        StartCoroutine(coroutine);
    }

    void Update()
    {

    }

    private IEnumerator Fadeit(float waitTime)
    {
        while (true)
        {
            //Handles the intro sequence -Dev
            yield return new WaitForSeconds(5);
            unityfade();
            yield return new WaitForSeconds(7);
            unityunfade();
            yield return new WaitForSeconds(7);
            asepritefade();
            yield return new WaitForSeconds(7);
            asepriteunfade();
            yield return new WaitForSeconds(10);
            LoadScene("Dev Scene");

        }
    }

    //The fade void's below -Dev
    void asepritefade()
    {
        asepriteimg.DOFade(1f, 7f);
    }
    void asepriteunfade()
    {
        asepriteimg.DOFade(0f, 7f);
    }

    void unityfade()
    {
        imagetest.DOFade(1f, 7f);
    }

    void unityunfade()
    {
        imagetest.DOFade(0f, 7f);
    }

    public void LoadScene(string sceneName)
    {
        //Scenechange script, changes the script that is referenced -Dev
        Debug.Log("SceneChange");
        SceneManager.LoadScene(sceneName);
    }
}
