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
        Damage = DamageMod.GetComponent<Weapons>();
        phealthmod = GameObject.Find("Health Maneger");
        pHealth = phealthmod.GetComponent<PlayerHelth>();
        EnemyPosition = GetComponent<Transform>();
       
    }

    private void Die()
    {
        
        canDoDamage = false;
        Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))
        {
            pInReach = false;
        }
        if (collision.CompareTag("PlayerHurtbox"))
        {
            eInReach = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))
        {
            pInReach = true;
        }
        
        if (collision.CompareTag("PlayerHurtbox"))
        {
            eInReach = true;
        }
    
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && pInReach == true)
        {
            eHealth -= Damage.Damage;
        }
        if (eHealth <= 0)
        {
            Instantiate(thingToSpawn, EnemyPosition);
            Destroy(gameObject);
        }
      


        if (timer >= 4 && eInReach == true)
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
