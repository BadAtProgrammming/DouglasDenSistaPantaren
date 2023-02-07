using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Made by Sixten
public class BuffGoon : MonoBehaviour
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



    [SerializeField] public int eHealth = 50;

    // Start is called before the first frame update
    void Start()
    {
        DamageMod = GameObject.Find("player");
        Damage = DamageMod.GetComponent<Weapons>();
        phealthmod = GameObject.Find("Health Maneger");
        pHealth = phealthmod.GetComponent<PlayerHelth>();
        EnemyPosition = GetComponent<Transform>();

    }

    private void Die()
    {
        canDoDamage = false;//If enemy is dead it can´t do damage -Sixten
        Destroy(gameObject);//Removes enemy when it is dead -Sixten
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))
        {
            pInReach = false;
        } //When there is no collition with the player attackbox the player is not in reach of the enemy -Sixten
        if (collision.CompareTag("PlayerHurtbox"))
        {
            eInReach = false;
        }//When there is no collition with the player hurtbox the enemy is not in reach of the player -Sixten
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))
        {
            pInReach = true;
        } // when there is a collition with the player attackbox the player is in reach of the enemy -Sixten

        if (collision.CompareTag("PlayerHurtbox"))
        {
            eInReach = true;
        }// when there is a collition with the player hurtbox the enemy is in reach of the player -Sixten

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && pInReach == true)
        {
            eHealth -= Damage.Damage;
        } //if you press N and the player is in reach of the enemy the enemy takes damage
        if (eHealth <= 0)
        {
            Instantiate(thingToSpawn, EnemyPosition);
            Destroy(gameObject);
        }//when the enemy dies it dropps "Pant"



        if (timer >= 4 && eInReach == true)
        {
            pHealth.Health -= 15;
            timer = 0;
        }// makes the enemy hurt the player every 4 seconds when in reach.

        timer += 1 * Time.deltaTime;

        if (eHealth <= 0 && candie)
        {
            candie = false;
            Instantiate(thingToSpawn, EnemyPosition.position, Quaternion.identity);
            Invoke("Die", 1);
        }
    }
}
