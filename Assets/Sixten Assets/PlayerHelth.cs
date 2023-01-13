using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHelth : MonoBehaviour
{
    GameObject CanvasObject;

    [SerializeField]
    public int Health;

    void Start()
    {
        //Sets object reference to find the deathcanvas, can also be set to a tag -Dev
        CanvasObject = GameObject.Find("DeathCanvas");
    }

    void Update()
    {
        //If you have no heath: show death screen -Sixten
        if (Health <= 0)
        {
            //When health 0 activates the entire canvasobject and its components -Dev
            CanvasObject.SetActive(true);
        }
        else if (Health >= 0)
        {
            //When Health is above 0 it deactivates it... Duuh -Dev
            CanvasObject.SetActive(false);
        }
    }
}
