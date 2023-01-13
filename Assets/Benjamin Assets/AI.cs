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
        IdleMoving 
    }

    private State _currentState; // represents current state of AI

    public Transform player;
    public bool PlayerDown;
    bool ReadyKick = true;
    bool ReadyPunch = true;
    int FramesPS = 30;
    float PunchTimer = 0;
    float KickTimer = 0;

    


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float DisengageRange = 21;
        float Reach = 2;
        float detectRange = 20;
        detectRange *= detectRange;
        float playerdistance = (player.position - transform.position).sqrMagnitude;

        PunchTimer += Time.deltaTime * FramesPS;
        KickTimer += Time.deltaTime * FramesPS;

        if (KickTimer >= 20)
        {
            ReadyKick = true;
        }

        if (PunchTimer >= 15)
        {
            ReadyPunch = true;
        }

        if (_currentState == State.Idle)
        {
            LookForPlayer();
            print("1");
        }
        if (_currentState == State.Chase)
        {
            ChasePlayer();
            print("2");
        }
        if (_currentState == State.Attack)
        {

            AttackPlayer();
            print("3");
        }
        if (_currentState == State.IdleMoving)
        {
            Strafing();
            print("4");
        }
        void LookForPlayer()
        {



            if (playerdistance <= DisengageRange)
            {
                _currentState = State.Chase;
            }



        }
        void ChasePlayer()
        {
            if (playerdistance <= detectRange)
            {

                Vector2 velocity = (player.transform.position - transform.position).normalized * Speed;
                rb.velocity = velocity;
            }
            if (playerdistance <= Reach)
            {
                rb.velocity = Vector2.zero;
                print("attack");
                _currentState = State.Attack;
            }
            else if (playerdistance >= DisengageRange)
            {
                rb.velocity = Vector2.zero;
                _currentState = State.Idle;
            }

        }
        void AttackPlayer()
        {
            
            if (playerdistance >= Reach)
            {
                _currentState = State.Chase;
            }
            if (ReadyPunch == true)
            {
             
            }
            if (ReadyKick == true)
            {

            }


        }
        void Strafing()
        {
            

         


        }
        



    }


}   





