using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    //Gotta reference everything since sixten got a skill issue -Dev
    GameObject healthmodel;
    PlayerHelth Health;

    void Start()
    {
        healthmodel = GameObject.Find("Health Maneger");
        Health = healthmodel.GetComponent<PlayerHelth>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Health.Health += 10;
        }
           
    }
}
