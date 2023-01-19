using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public GeneralShopSystem NowDoneshopping1;
    public PantManager ShopPoint;
    // Start is called before the first frame update
    void Start()
    {
        NowDoneshopping1 = FindObjectOfType<GeneralShopSystem>();
        ShopPoint = FindObjectOfType<PantManager>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void doneshopping1()
    {
        GameObject.Find("ShopUI").SetActive(false);
        NowDoneshopping1.Doneshopping1 = true;
        Destroy(gameObject);
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
