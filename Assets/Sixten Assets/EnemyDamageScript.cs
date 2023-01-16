using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour
{// set this on the enemy attack hitbox, not on enemy itself
    [SerializeField] public int Damage = 2; //set damage
    public PlayerHelth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHelth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            playerHealth.Health -= Damage;
        }
    }
}
