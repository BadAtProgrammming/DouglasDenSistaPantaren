using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public PlayerHelth pHealth;

    public bool eInReach;
    // Start is called before the first frame update
    void Start()
    {
        pHealth = FindObjectOfType<PlayerHelth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }

}
