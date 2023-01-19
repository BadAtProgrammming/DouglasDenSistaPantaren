using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralShopSystem : MonoBehaviour
{
    public bool Doneshopping1;
    public GameObject shopthing;
    public bool Doneshopping2;
    // Start is called before the first frame update
    void Start()
    { 
        shopthing = GameObject.Find("ShopUI");
        shopthing.SetActive(false);
        Doneshopping1 = false;
        Doneshopping2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
