using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class AI : MonoBehaviour
{
    float Speed = 2;
    Rigidbody2D rb;
    private enum State
    {
        Idle,
        Chase,
        Attack,
        IdleMoving, 
        TakeDamage //States to group together actions
    }

    private State _currentState; // represents current state of AI

    public Transform player; // So the asset can use transform everywhere in the code.
    Coroutine coroutine;
    private SpriteRenderer spriteRenderer;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // so the asset can reference Rigidbody without having to write it in several times.
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        int StrafeLuck = 0;
        float DisengageRange = 21;
        float Reach = 2;
        float detectRange = 20;
        detectRange *= detectRange;
        float playerdistance = (player.position - transform.position).sqrMagnitude; // responsible for if the ai can see the player or not


        if (_currentState == State.Idle) //Idle doesnt do much, just a state for the other states to change from. Also a State for LookForPlayer() to change to other states
        {
            LookForPlayer();
        }
        if (_currentState == State.Chase) // State for ChasePlayer()
        {
            ChasePlayer();
        }
        if (_currentState == State.Attack) // State for AttackPlayer()
        {

            AttackPlayer();
        }
        if (_currentState == State.IdleMoving) // State for Strafing()
        {
            Strafing();
        }
        void LookForPlayer()
        {
            


            if (playerdistance <= DisengageRange)  // Checks if player is close enough to enemy - benjamin
            {
                _currentState = State.Chase;
            }



        }
        
        void ChasePlayer() // Code for the enemy to chase the player - benjamin
        {
            spriteRenderer.flipX = player.transform.position.x > transform.position.x;
            if (playerdistance <= detectRange)
            {
                rb.velocity = Vector2.zero;
                Vector2 velocity = (player.transform.position - transform.position).normalized * Speed;
                rb.velocity = velocity;
                transform.localScale = new Vector2(-3,3);
                

            }
            if (playerdistance <= Reach)
            {
                rb.velocity = Vector2.zero;
                _currentState = State.Attack;
                transform.localScale = new Vector2(3,3);
            }
            else if (playerdistance >= DisengageRange)
            {
                rb.velocity = Vector2.zero;
                _currentState = State.Idle;
            }

        }
        void AttackPlayer() //Code to make the enemy to stop at the player's location and use attack animations to hit them, currently doesnt do much. - benjamin
        {
            spriteRenderer.flipX = player.transform.position.x < transform.position.x; // flips position so the animations are pointed the right way
            Animator anim;
            anim = GetComponent<Animator>();
            if (playerdistance <= Reach)
            {
                rb.velocity = Vector2.zero;
                anim.SetBool("AITTACK", true);
            }
            else if(playerdistance >= Reach)
            {
                rb.velocity = Vector2.zero;
                _currentState = State.Chase;
                anim.SetBool("AITTACK", false);
            }
            StrafeLuck = Random.Range(0, 640);
            if (StrafeLuck == 1)
            {
                _currentState = State.IdleMoving;
            }

        }
        void Strafing()
        {
            //Code to make enemy character run away after for example player is hit or downed, works? - benjamin
            Animator anim;
            anim = GetComponent<Animator>();
            if (_currentState == State.IdleMoving)
            {
                anim.SetBool("AITTACK", false);
                Vector2 velocity = (transform.position - player.transform.position).normalized * Speed;
                rb.velocity = velocity;
                coroutine = StartCoroutine(StrafeTimer());
                TakenDamage();
            }
            
        
        }

        void TakenDamage()
        {
            if(_currentState == State.TakeDamage)
            {
                HitStun();
            }
        }
        
        IEnumerator StrafeTimer() // Coroutine to wait x seconds to switch to chase state from strafing.
        {
            yield return new WaitForSeconds(2f);
            _currentState = State.Chase;
            coroutine = null;
        }

        IEnumerator HitStun()
        {
            yield return new WaitForSeconds(0.2f);
        }


    
    
    }


}   





