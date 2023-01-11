using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    bool ReadyKick = true;
    bool ReadyPunch = true;
    int FramesPS = 30;
    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float PunchTimer = Time.deltaTime * FramesPS;
        float KickTimer = Time.deltaTime * FramesPS;


        #region buttons
        if (Input.GetKey(KeyCode.R) && ReadyKick == true)
        {
            print("Kick");
            KickTimer = 0;
            ReadyKick = false;
        }
        if (Input.GetKey(KeyCode.E) && ReadyPunch == true) 
        {
            print("Punch");
            PunchTimer = 0;
            ReadyPunch = false;
        }
        #endregion

        if(KickTimer >= 20)
        {
            ReadyKick = true;
        }

        if (PunchTimer >= 15)
        {
            ReadyPunch = true;
        }

    }
}
