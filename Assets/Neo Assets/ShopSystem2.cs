using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem2 : MonoBehaviour
{
    public GeneralShopSystem shopthinging;
    public GeneralShopSystem NowDoneshopping2;
    public GeneralShopSystem NowDoneshopping1;
    public PantScore ShopPoint;
    // Start is called before the first frame update
    void Start()
    {
        shopthinging =  FindObjectOfType<GeneralShopSystem>();
        NowDoneshopping2 = FindObjectOfType<GeneralShopSystem>();
        NowDoneshopping1 = FindObjectOfType<GeneralShopSystem>();
        ShopPoint = FindObjectOfType<PantScore>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void doneshopping2()
    {
        if (NowDoneshopping1.Doneshopping1)
        {
            NowDoneshopping2.Doneshopping2 = true;
            shopthinging.shopthing.SetActive(false);
            Destroy(gameObject);
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
