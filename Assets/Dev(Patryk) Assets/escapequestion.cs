using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class escapequestion : MonoBehaviour
{

    GameObject canvasobject;
    Canvas canvasdefined;
    RectTransform transformcanvas;

    // Start is called before the first frame update
    void Start()
    {
        canvasobject = GameObject.Find("EscapeQuestion");
        canvasdefined = canvasobject.GetComponent<Canvas>();
        transformcanvas = canvasobject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transformcanvas.anchoredPosition = new Vector3(0f, 0f, 0f);
        }
    }


    public void runitback()
    {
        transformcanvas.anchoredPosition = new Vector3(0f,1000f,0f);
    }
}
