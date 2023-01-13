using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Garbage : MonoBehaviour
{
    
    Rigidbody2D rb;

    private enum State
    {
        Idle,
        SeePlayer,
        Chase,
        Attack,
        IdleMoving
    }

    private State _currentState; // represents current state of AI

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            
            _currentState = State.Idle;
            switch (_currentState)
            {
                case State.Idle:
                    print("IdleState"); 
                    LookForPlayer();
                    break;
                case State.Chase:
                    print("chasestate");
                    ChasePlayer();
                    break;
            }
            yield return 0;
        }  
            
        
    }
    public Transform player;
    private void LookForPlayer()
    {


        {
            
            {
                if (_currentState == State.Idle)
                {
                    float detectRange = 10;
                    detectRange *= detectRange;
                    float playerdistance = (player.position - transform.position).sqrMagnitude;
                    if (playerdistance <= detectRange)
                    {
                        _currentState = State.Chase;
                    }
                    
                }
                
            }   
        }   
    }

    
    private void ChasePlayer()
    {

        float Speed = 2;
        if (_currentState == State.Chase)
        { 
        Vector2 velocity = (player.transform.position - transform.position).normalized * Speed;
        }
    }


    private void Awake()
    {
        _currentState = State.Idle;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_currentState == State.Idle)
        {
            LookForPlayer();
        }
        if (_currentState == State.Chase)
        {
            ChasePlayer();
        }
    }

}    
