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
            HasWeapon = true;
        }

    // Update is called once per frame
    void Update()
    {
        if (Microsoft == true || LightBlade == true || Umbrella == true || Pan == true || Axe == true)
        {
            anim.SetBool("HasSign", false);
        }

        if (Sign == true || LightBlade == true || Umbrella == true || Pan == true || Axe == true)
        {
            anim.SetBool("HasEdge", false);
        }

        if (Sign == true || Microsoft == true || Umbrella == true || Pan == true || Axe == true)
        {
            anim.SetBool("HasBlade", false);
        }

        if (Sign == true || LightBlade == true || Microsoft == true || Pan == true || Axe == true)
        {
            anim.SetBool("HasUmbrella", false);
        }

        if (Sign == true || LightBlade == true || Umbrella == true || Microsoft == true || Axe == true)
        {
            anim.SetBool("HasPan", false);
        }

        if (Sign == false && Microsoft == false && LightBlade == false && Umbrella == false && Axe == false && Pan == false)
        {
            anim.SetBool("HasWeapon", false);
            HasWeapon = false;
            
        }
    }

    //Functions to invoke with buttons!
    public void Signfun()
    {
        Sign = true;
        if (Sign == true)
        {
            Microsoft = false;
            LightBlade = false;
            Umbrella = false;
            Pan = false;
            Axe = false;
            anim.SetBool("HasSign", true);
            anim.SetBool("HasWeapon", true);
        }
    }
    public void MicrosoftFun()
    {
        Microsoft = true;
        if (Microsoft == true)
        {
            LightBlade = false;
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            anim.SetBool("HasEdge", true);
            anim.SetBool("HasWeapon", true);
        }
    }
    public void LightBladeFun()
    {
        LightBlade = true;
        if (LightBlade == true)
        {
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            anim.SetBool("HasBlade", true);
            anim.SetBool("HasWeapon", true);
        }
    }
    public void UmbrellaFun()
    {
        Umbrella = true;
        if (Umbrella == true)
        {
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            anim.SetBool("HasWeapon", true);
            anim.SetBool("HasUmbrella", true);
        }
    }
    public void AxeFun()
    {
        Axe = true;
        if (Axe == true)
        {
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Pan = false;
            Umbrella = false;
            anim.SetBool("HasAxe", true);
            anim.SetBool("HasWeapon", true);
        }
    }
    public void PanFun()
    {
        Pan = true;
        if (Pan == true)
        {
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Axe = false;
            Umbrella = false;
            anim.SetBool("HasPan", true);
            anim.SetBool("HasWeapon", true);
        }
    }
}
