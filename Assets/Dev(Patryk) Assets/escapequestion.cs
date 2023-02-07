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
    void Start() //Reference the referencey references (Im dead inside now) -Dev
    {
        canvasobject = GameObject.Find("EscapeQuestion");
        canvasdefined = canvasobject.GetComponent<Canvas>();
        transformcanvas = canvasobject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update() //By now, you shoul know what update is, and so do I... Yeah bscly yeah checks if escape duuh! -Dev
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transformcanvas.anchoredPosition = new Vector3(0f, 0f, 0f);
        }
    }


    public void runitback() //RUN IT BACK PRIVATE! (Resets the canvas position, ik im a memer dont worry) -Dev
    {
        transformcanvas.anchoredPosition = new Vector3(0f,1000f,0f);
    }
}
