using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    public bool ReadyKick = true;
    public bool ReadyPunch = true;
    int FramesPS = 30;
    float PunchTimer = 0;
    float KickTimer = 0;
    public float WeaponCooldown=15;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PunchTimer += Time.deltaTime * FramesPS;
        KickTimer += Time.deltaTime * FramesPS;



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

        if (PunchTimer >= WeaponCooldown)
        {
            ReadyPunch = true;
        }
        
    }

}
