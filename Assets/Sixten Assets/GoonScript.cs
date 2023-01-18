using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoonScript : MonoBehaviour
{
    [SerializeField]
    GameObject thingToSpawn;

    private Transform EnemyPosition;
    public bool inReach;
    [SerializeField] int Health = 20;
    // Start is called before the first frame update
    void Start()
    {
        EnemyPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inReach == true)
        {
            
            Health -= 10;
        }
        if(Health<= 0)
        {
            Instantiate(thingToSpawn, EnemyPosition);
            
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerAttackbox"))
        {
            inReach = true;
        }
        else
        {
            inReach = false;
            
        }
    }
}
