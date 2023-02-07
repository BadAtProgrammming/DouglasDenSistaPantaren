using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class escapequestion : MonoBehaviour
{

    GameObject canvasobject;
    Canvas canvasdefined;

    // Start is called before the first frame update
    void Start()
    {
        canvasobject = GameObject.Find("EscapeQuestion");
        canvasdefined = canvasobject.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

        }
    }
}
