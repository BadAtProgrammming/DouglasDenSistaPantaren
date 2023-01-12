using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{

    public GameObject[] TierOne;
    public Transform SpawnLocation;
    public PantManager pantpoint;
    // Start is called before the first frame update
    void Start()
    {
        pantpoint = FindObjectOfType<PantManager>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Shop"))
        {
            print("touch");
        }
    }



}
