using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    bool ReadyKick = true;
    bool ReadyPunch = true;
    int FramesPS = 30;
    float PunchTimer = 0;
    float KickTimer = 0;
    public float WeaponCooldown=15;
    float ComboStep1;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("PunchOne", false);
        anim.SetBool("PunchTwo", true);
    }

    // Update is called once per frame
    void Update()
    {
        PunchTimer += Time.deltaTime * FramesPS;
        KickTimer += Time.deltaTime * FramesPS;
        ComboStep1 += Time.deltaTime * FramesPS;



        #region buttons
        if (Input.GetKey(KeyCode.M) && ReadyKick == true)
        {
            print("m");
            KickTimer = 0;
            ReadyKick = false;
        }
        
        
        
        if (Input.GetKey(KeyCode.N) && ReadyPunch == true) 
        {
            anim.SetBool("PunchOne", true);
            PunchTimer = 0;
            ReadyPunch = false;
            ComboStep1 = 0;
        }
        else{
            anim.SetBool("PunchOne", false);
        }
        if (Input.GetKey(KeyCode.N) && ComboStep1 >= 5 && PunchTimer <= WeaponCooldown){
            anim.SetBool("PunchTwo", true);
        }
        else{
            anim.SetBool("PunchTwo", false);
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
