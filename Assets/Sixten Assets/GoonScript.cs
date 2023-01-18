using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoonScript : MonoBehaviour
{
    public PlayerHelth pHealth;
    public bool eInReach;
    [SerializeField] GameObject thingToSpawn;
    public bool canDoDamage;
    private bool candie = true;
    private Transform EnemyPosition;
    float timer;
    public bool pInReach;
    


    [SerializeField] public int Health = 20;

    // Start is called before the first frame update
    void Start()
    {
        pHealth = FindObjectOfType<PlayerHelth>();
        EnemyPosition = GetComponent<Transform>();
       
    }

    private void Die()
    {
        
        canDoDamage = false;
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))
        {
            pInReach = true;
        }
        else
        {
            pInReach = false;
            
        }
        if (collision.CompareTag("PlayerHurtbox"))
        {
            eInReach = true;
        }
        else
        {
            eInReach = false;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && pInReach == true)
        {
            Health -= 10;
        }
        if (Health <= 0)
        {
            Instantiate(thingToSpawn, EnemyPosition);
            Destroy(gameObject);
        }
        if (timer >= 4 && eInReach == true)
        {
            canDoDamage = true;
        }
        else
        {
            canDoDamage = false;
        }
        if (canDoDamage == true)
        {
            pHealth.Health -= 10;
            timer = 0;
        }
        timer += 1 * Time.deltaTime;

        if (Health <= 0 && candie)
        {
            candie = false;
            Instantiate(thingToSpawn, EnemyPosition.position, Quaternion.identity);
            Invoke("Die", 1);
        }
    }
}
