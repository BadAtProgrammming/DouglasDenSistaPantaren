using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoonScript : MonoBehaviour
{
    public PlayerTakeDamage eInReach;
    [SerializeField] GameObject thingToSpawn;

    private bool candie = true;
    private Transform EnemyPosition;

    public bool pInReach;
    


    [SerializeField] public int Health = 20;

    // Start is called before the first frame update
    void Start()
    {
        EnemyPosition = GetComponent<Transform>();
        eInReach = FindObjectOfType<PlayerTakeDamage>();
    }

    private void Die()
    {
        
        eInReach.eInReach = false;
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

        if (Health <= 0 && candie)
        {
            candie = false;
            Instantiate(thingToSpawn, EnemyPosition.position, Quaternion.identity);
            Invoke("Die", 1);
        }
    }
}
