using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public GeneralShopSystem shopthinging;
    public GeneralShopSystem NowDoneshopping1;
    public PantScore ShopPoint;
    // Start is called before the first frame update
    void Start()
    {
        shopthinging =  FindObjectOfType<GeneralShopSystem>();
        NowDoneshopping1 = FindObjectOfType<GeneralShopSystem>();
        ShopPoint = FindObjectOfType<PantScore>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void doneshopping1()
    {
        shopthinging.shopthing.SetActive(false);
        NowDoneshopping1.Doneshopping1 = true;
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.CompareTag("player"))
        {
            Debug.Log("touch");
            shopthinging.shopthing.SetActive(true);
        }
    }
}
