using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    PlayerHelth Health;
    // Start is called before the first frame update
    void Start()
    {
        Health = FindObjectOfType<PlayerHelth>();
    }

    // Update is called once per frame
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
