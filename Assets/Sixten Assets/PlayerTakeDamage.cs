using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public PlayerHelth pHealth;
    float timer;
    bool canTakeDamage;
    public bool eInReach;
    // Start is called before the first frame update
    void Start()
    {
        pHealth = FindObjectOfType<PlayerHelth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= 4 && eInReach == true)
        {
            canTakeDamage = true;
        }
        else
        {
            canTakeDamage = false;
        }
        if(timer >= 4 && canTakeDamage == true)
        {
            pHealth.Health -= 10;
            timer = 0;
        }
        timer += 1 * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyAttackbox"))
        {
            eInReach = true;
        }
        else
        {
            eInReach = false;

        }
    }
}
