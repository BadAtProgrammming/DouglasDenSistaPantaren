using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem3 : MonoBehaviour
{
    public GeneralShopSystem shopthinging;
    public GeneralShopSystem NowDoneshopping2;
    public PantScore ShopPoint;
    // Start is called before the first frame update
    void Start()
    {
        shopthinging =  FindObjectOfType<GeneralShopSystem>();
        NowDoneshopping2 = FindObjectOfType<GeneralShopSystem>();
        ShopPoint = FindObjectOfType<PantScore>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void doneshopping3()
    {
        if (NowDoneshopping2.Doneshopping2)
        {
            shopthinging.shopthing.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            print("touch");
            shopthinging.shopthing.SetActive(true);
        }
    }
}