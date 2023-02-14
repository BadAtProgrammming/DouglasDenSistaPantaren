using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Made by Sixten
public class GoonScript : MonoBehaviour
{
    GameObject DamageMod;
    public Weapons Damage;

    GameObject phealthmod;
    public PlayerHelth pHealth;
    public bool eInReach;
    [SerializeField] GameObject thingToSpawn;
    public bool canDoDamage;
    private bool candie = true;
    private Transform EnemyPosition;
    float timer;
    public bool pInReach;
    


    [SerializeField] public int eHealth = 20;

    // Start is called before the first frame update
    void Start()
    {
        DamageMod = GameObject.Find("player");
        Damage = DamageMod.GetComponent<Weapons>(); //refrenses what weapon the player has and dus how mutch damage the player does -Sixten

        phealthmod = GameObject.Find("Health Maneger");
        pHealth = phealthmod.GetComponent<PlayerHelth>();//refrenses the players health -Sixten

        EnemyPosition = GetComponent<Transform>();//refrenses the enemy's position -Sixten

    }

    private void Die()//if the enemy dies it can't do damage and it is destroid -Sixten
    {
        
        canDoDamage = false;
        Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))//if the player's attack box stops colliding with the enemy, the enemy can't take damage -Sixten
        {
            pInReach = false;
        }
        if (collision.CompareTag("PlayerHurtbox"))//If the enemy's attack box stops colliding with the player it can't do damage to the palyer -Sixten
        {
            eInReach = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))//if the player's attack box is colliding with the enemy, the enemy can take damage -Sixten
        {
            pInReach = true;
        }
        
        if (collision.CompareTag("PlayerHurtbox"))//If the enemy's attack box is colliding with the player it can do damage to the palyer -Sixten
        {
            eInReach = true;
        }
    
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && pInReach == true)//if the enemy is in reach and you press the attack button the enemy takes damage -Sixten
        {
            eHealth -= Damage.Damage;
        }
        if (eHealth <= 0)//when the enemy dies it gets destroid and spawnes a "pant" -Sixten
        {
            Instantiate(thingToSpawn, EnemyPosition);
            Destroy(gameObject);
        }
      


        if (timer >= 4 && eInReach == true)//when the player is in reach of the enemy the enemy deals damadge to the player every 4 seconds -Sixten
        { 
            pHealth.TakeDamage(10);
            timer = 0;
        }
        timer += 1 * Time.deltaTime;

        if (eHealth <= 0 && candie)
        {
            candie = false;
            Instantiate(thingToSpawn, EnemyPosition.position, Quaternion.identity);
            Invoke("Die", 1);
        }
    }
}
