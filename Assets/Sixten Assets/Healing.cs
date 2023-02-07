using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//By Sixten
public class Healing : MonoBehaviour
{
 
    GameObject healthmodel;
    PlayerHelth Health;

    void Start()
    {
        healthmodel = GameObject.Find("Health Maneger");
        Health = healthmodel.GetComponent<PlayerHelth>();
    } //refrenses player helth

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //this heals the player
        if (collision.CompareTag("player"))
        {
            Health.Health += 10;
        }
           
    }
}
