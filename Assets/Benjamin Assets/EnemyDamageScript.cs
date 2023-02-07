using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour
{// set this on the enemy attack hitbox, not on enemy itself -Sixten
    [SerializeField] public int Damage = 2; //set damage
    public PlayerHelth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHelth>();//find the player heath script -Sixten & Daniel
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerHurtbox"))//if collision with player: take damage -Sixten & Daniel
        {
            playerHealth.Health -= Damage;
        }
    }
}
