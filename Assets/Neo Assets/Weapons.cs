using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    //sign damage 15
    //microsoft Edge damage 999
    //LightSaber 60 damage
    //Umbrella 20 damage
    //Axe 50 damage
    //Pan 40 damage
    //Bear Fists 10 damage
    // Start is called before the first frame update
    Animator anim;
    public bool Unarmed;
    public bool HasWeapon;
    public bool Sign;
    public bool Microsoft;
    public bool LightBlade;
    public bool Umbrella;
    public bool Pan;
    public bool Axe;
    public EnemyDamageScript Weapondamage;
        void Start()
        {
            Weapondamage = FindObjectOfType<EnemyDamageScript>();
            anim = GetComponent<Animator>();
            anim.SetBool("HasSign", true);
            anim.SetBool("HasWeapon", true);
            
            
        }

    // Update is called once per frame
    void Update()
    {
        if (Sign)
        { 
          Microsoft = false;
          LightBlade = false;
          Umbrella = false;
          Pan = false;
          Axe = false;
          Weapondamage.Damage = 15;
          anim.SetBool("HasSign", true);
          anim.SetBool("HasWeapon", true);
        }
        else
        {
            anim.SetBool("HasSign", false);
        }

        if (Microsoft)
        {
            LightBlade = false;
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            Weapondamage.Damage = 999;
            anim.SetBool("HasEdge", true);
            anim.SetBool("HasWeapon", true);
        }
        else
        {
            anim.SetBool("HasEdge", false);
        }

        if (LightBlade)
        {
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            Weapondamage.Damage = 60;
            anim.SetBool("HasBlade", true);
            anim.SetBool("HasWeapon", true);
        }
        else
        {
            anim.SetBool("HasBlade", false);
        }

        if (Umbrella)
        {
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Weapondamage.Damage = 20;
            anim.SetBool("HasWeapon", true);
            anim.SetBool("HasUmbrella", true);
        }
        else
        {
            anim.SetBool("HasUmbrella", false);
        }


        if (Axe)
        {
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Pan = false;
            Umbrella = false;
            Weapondamage.Damage = 50;
            anim.SetBool("HasAxe", true);
            anim.SetBool("HasWeapon", true);
        }

        if (Pan)
        {
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Axe = false;
            Umbrella = false;
            anim.SetBool("HasPan", true);
            anim.SetBool("HasWeapon", true);
        }
        else
        {
            anim.SetBool("HasPan", false);
        }

        if (Sign == false && Microsoft == false && LightBlade == false && Umbrella == false && Axe == false && Pan == false)
        {
            anim.SetBool("HasWeapon", false);
            HasWeapon = false;
        }
        else
        {
            HasWeapon = true;
        }
        if(HasWeapon == true)
        {
            Unarmed = false;
        }
        else 
        {
            Unarmed = true;
        }
    }
}
