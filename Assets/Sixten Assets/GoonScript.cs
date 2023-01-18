using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoonScript : MonoBehaviour
{
    [SerializeField] GameObject thingToSpawn;

    private bool candie = true;
    private Transform EnemyPosition;

    public bool pInReach;
    public bool inReach;


    [SerializeField] int Health = 20;

    // Start is called before the first frame update
    void Start()
    {
        EnemyPosition = GetComponent<Transform>();
    }

    private void Die()
    {
        if (Input.GetKeyDown(KeyCode.N) && pInReach == true)
        {
            Health -= 10;
        }
        if(Health<= 0)
        {
            Instantiate(thingToSpawn, EnemyPosition);
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerHurtbox"))
        {
            pInReach = true;
        }
        else
        {
            pInReach = false;
            inReach = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && inReach == true)
        {
            Health -= 10;
        }

        if (Health <= 0 && candie)
        {
            candie = false;
            Instantiate(thingToSpawn, EnemyPosition.position, Quaternion.identity);
            Invoke("Die", 1);
        }
    }
}
