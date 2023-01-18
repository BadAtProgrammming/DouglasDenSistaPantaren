using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class ActualCreditsFunctions : MonoBehaviour
{
    GameObject background;
    GameObject foreground;
    GameObject credits;
    GameObject canvas;

    void Start()
    {
        background = GameObject.Find("Background");
        foreground = GameObject.Find("BackgroundScreen");
        credits = GameObject.Find("Credits");
        canvas = GameObject.Find("CreditCanvas");

    }



    void Update()
    {
        
    }

    public void moveup()
    {
        background.transform.DOLocalMoveY(984f, 5f, false);
        foreground.transform.DOLocalMoveY(984f, 5f, false);
        credits.transform.DOLocalMoveY(88f, 5f, false);
        canvas.transform.DOLocalMoveY(-3.0001f, 5f, false);
    }

    public void moveback()
    {
        background.transform.DOLocalMoveY(-3f, 5f, false);
        foreground.transform.DOLocalMoveY(-3f, 5f, false);
        credits.transform.DOLocalMoveY(-899f, 5f, false);
        canvas.transform.DOLocalMoveY(-986.9999f, 5f, false);
    }

}
