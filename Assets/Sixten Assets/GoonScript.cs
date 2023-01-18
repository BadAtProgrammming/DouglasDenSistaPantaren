using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoonScript : MonoBehaviour
{
    [SerializeField] GameObject thingToSpawn;

    private bool candie = true;
    private Transform EnemyPosition;
<<<<<<< HEAD
    public bool pInReach;
=======
    public bool inReach;

>>>>>>> 860f88c7ac560926d8c54f39bda7bff2af3445a9
    [SerializeField] int Health = 20;

    // Start is called before the first frame update
    void Start()
    {
        EnemyPosition = GetComponent<Transform>();
    }

    private void Die()
    {
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.N) && pInReach == true)
        {
            
            Health -= 10;
        }
        if(Health<= 0)
        {
            Instantiate(thingToSpawn, EnemyPosition);
            
            Destroy(gameObject);
        }
=======
        Destroy(gameObject);
>>>>>>> 860f88c7ac560926d8c54f39bda7bff2af3445a9
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerHurtbox"))
        {
            pInReach = true;
        }
        else
        {
<<<<<<< HEAD
            pInReach = false;
            
=======
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
>>>>>>> 860f88c7ac560926d8c54f39bda7bff2af3445a9
        }
    }
}
