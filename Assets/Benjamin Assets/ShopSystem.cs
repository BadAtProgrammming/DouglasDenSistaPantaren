using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{

    public GameObject[] TierOne;
    public Transform SpawnLocation;
    private int pantpoint;
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

                Instantiate(TierOne[Random.Range(0, 2)], SpawnLocation.position, SpawnLocation.rotation);
            }
        }
    }



}
