using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    bool ReadyKick = true;
    bool ReadyPunch = true;
    int FramesPS = 30;
    float PunchTimer;
    float KickTimer;
    public float WeaponCooldown=15;
    float ComboStep1;
    float WeaponTimer;
    private Weapons weapons;
    public bool Swinging;
    Animator anim;
    // Start is called before the first frame update
    
        private void Awake()
    {
        weapons = GetComponent<Weapons>();
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("PunchOne", false);
        anim.SetBool("PunchTwo", true);
    }

    

    // Update is called once per frame
    void Update()
    {
        PunchTimer += Time.deltaTime * FramesPS; //not actual frames per second, just a dumb name. - benjamin (These are just timers for different things.)
        KickTimer += Time.deltaTime * FramesPS;
        ComboStep1 += Time.deltaTime * FramesPS;
        WeaponTimer += Time.deltaTime * FramesPS;

        #region Buttons
        if (Input.GetKeyDown(KeyCode.N) && ReadyPunch == true && weapons.Unarmed == true && PunchTimer >= 15) // system for if character punches one or twice. lets player keep pressing the button to loop the anim. - benjamin
        {
            anim.SetBool("PunchOne", true);
            PunchTimer = 0;
            ReadyPunch = false;
            ComboStep1 = 0;
        } 
        else{
            anim.SetBool("PunchOne", false);
        }
        if (Input.GetKeyDown(KeyCode.N) && ComboStep1 >= 5 && PunchTimer <= WeaponCooldown){ // Second punch attack - benjamin
            anim.SetBool("PunchTwo", true);
        }
        else{
            anim.SetBool("PunchTwo", false);
        }
        #endregion
       
        if (PunchTimer >= WeaponCooldown) //punch cooldown - benjamin
        {
            ReadyPunch = true;
        }

        if (Input.GetKeyDown(KeyCode.N) && weapons.HasWeapon == true && ReadyKick == true) // checks if character should swing weapon - benjamin
        {
            anim.SetBool("ReadySwing", true);
            Swinging = true;
        }
        else{
            anim.SetBool("ReadySwing", false);
            Swinging = false;
        }
        
       
    }

}
