using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem2 : MonoBehaviour
{
    public GeneralShopSystem NowDoneshopping2;
    public GeneralShopSystem NowDoneshopping1;
    public PantManager ShopPoint;
    // Start is called before the first frame update
    void Start()
    {
        NowDoneshopping2 = FindObjectOfType<GeneralShopSystem>();
        NowDoneshopping1 = FindObjectOfType<GeneralShopSystem>();
        ShopPoint = FindObjectOfType<PantManager>();
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
            GameObject.Find("ShopUI").SetActive(false);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            print("touch");
            GameObject.Find("ShopUI").SetActive(true);
        }
    }
}
