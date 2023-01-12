using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{

    private int pantpoint;
    [SerializeField] GameObject[] WeaponTierOne;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("ShopArea").GetComponent<PantManager>().pantpoint = 0;
        print(pantpoint);
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            print("touch");
            if (pantpoint >= 50)
            {
               string[] WeaponTierOne = new string[] { "ProtestSign", "Umbrella" };
            }
        }
    }



}
