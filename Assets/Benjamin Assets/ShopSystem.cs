using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{

    
   
    // Start is called before the first frame update
    void Start()
    {
       GameObject.Find("pantpoint").GetComponent<PantManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
