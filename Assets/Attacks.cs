using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{




    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float PunchTimer = Time.deltaTime;
        float KickTimer = Time.deltaTime;

        bool ReadyKick = true;
        bool ReadyPunch = true;



        if (Input.GetKey(KeyCode.R) && ReadyKick == true)
        {
            print("Kick");
            KickTimer = 0;
        }
        if (Input.GetKey(KeyCode.E) && ReadyPunch == true) 
        {
            print("Punch");
            PunchTimer = 0;
        }
    }
}
