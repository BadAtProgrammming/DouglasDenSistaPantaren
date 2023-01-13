using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHelth : MonoBehaviour
{
    Canvas CanvasObject;

    [SerializeField]
    public int Health;
    // Start is called before the first frame update
    void Start()
    {
        //Sets object reference to find the deathcanvas, can also be set to a tag -Dev
        CanvasObject = FindObjectOfType<Canvas>();
        //Debug purposes -Dev
        CanvasObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //If you have no heath: show death screen -Sixten
        if (Health <= 0)
        {
            CanvasObject.gameObject.SetActive(true);
        }
    }
}
