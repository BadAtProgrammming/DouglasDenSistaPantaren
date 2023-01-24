using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralShopSystem : MonoBehaviour
{
    public GameObject shopthing;
    // Start is called before the first frame update
    void Start()
    { 
        shopthing = GameObject.Find("ShopUI");
        shopthing.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
