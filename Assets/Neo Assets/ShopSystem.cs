using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    //gets acces to currency and the shop UI - Daniel
    public GeneralShopSystem shopthinging;
    public PantScore ShopPoint;
    // Start is called before the first frame update
    void Start()
    {
        shopthinging =  FindObjectOfType<GeneralShopSystem>();
        ShopPoint = FindObjectOfType<PantScore>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void doneshopping1() //turns of the shop UI when something is bought or if exit shop - Daniel
    {
        shopthinging.shopthing.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D trigger)//on collision with shop start shopping - Daniel
    {
        if(trigger.gameObject.CompareTag("player"))
        {
            Debug.Log("touch");
            shopthinging.shopthing.SetActive(true);
        }
    }
}
