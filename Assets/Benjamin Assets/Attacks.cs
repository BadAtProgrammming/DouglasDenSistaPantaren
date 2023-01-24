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
        PunchTimer += Time.deltaTime * FramesPS; //not actual frames per second, just a dumb name.
        KickTimer += Time.deltaTime * FramesPS;
        ComboStep1 += Time.deltaTime * FramesPS;
        WeaponTimer += Time.deltaTime * FramesPS;



        #region buttons
        if (Input.GetKey(KeyCode.M) && ReadyKick == true && weapons.Unarmed == true) // scrapped code ignore
        {
            print("m");
            KickTimer = 0;
            ReadyKick = false;
        }
        
        
        
        if (Input.GetKey(KeyCode.N) && ReadyPunch == true && weapons.Unarmed == true && PunchTimer >= 15) // system for if character punches one or twice. lets player keep pressing the button to loop the anim.
        {
            anim.SetBool("PunchOne", true);
            PunchTimer = 0;
            ReadyPunch = false;
            ComboStep1 = 0;
        } 
        else{
            anim.SetBool("PunchOne", false);
        }
        if (Input.GetKey(KeyCode.N) && ComboStep1 >= 5 && PunchTimer <= WeaponCooldown){ // Second punch attack
            anim.SetBool("PunchTwo", true);
        }
        else{
            anim.SetBool("PunchTwo", false);
        }
        #endregion

        if(KickTimer >= 20) // scrapped code for kick attack
        {
            ReadyKick = true;
        }
       

        if (PunchTimer >= WeaponCooldown) //punch cooldown
        {
            ReadyPunch = true;
        }

        if (Input.GetKey(KeyCode.N) && weapons.Unarmed == false && weapons.HasWeapon == true && ReadyKick == true) // checks if character should swing weapon
        {
            print("Attackswing");
            anim.SetBool("ReadySwing", true);
            Swinging = true;
        }else {
            anim.SetBool("ReadySwing", false);
            Swinging = false;
        }
        
       
    }

}
