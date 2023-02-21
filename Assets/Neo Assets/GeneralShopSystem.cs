using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralShopSystem : MonoBehaviour
{// gör så shop UI fungerar utan problem - daniel
    public GameObject shopthing;
    // Start is called before the first frame update
    void Start()
    { // gör så shop UI fungerar utan problem - daniel
        shopthing = GameObject.Find("ShopUI");
        shopthing.SetActive(false); //turn of shop UI on start
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
