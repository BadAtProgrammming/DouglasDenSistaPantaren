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
    public int Durability;
    public int Damage;
    
    GameObject pantmodel;
    PantScore Pant;
    
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
        pantmodel = GameObject.Find("player");
        Pant = pantmodel.GetComponent<PantScore>();
        Weapondamage = FindObjectOfType<EnemyDamageScript>();
            anim = GetComponent<Animator>();
            Signfun();
        }

    public void Dura()
    {
        print("hej");
        Durability -= 1;
        if (Durability <= 0)
        {
            anim.SetBool("HasWeapon", false);
            anim.SetBool("HasSign", false);
            anim.SetBool("HasEdge", false);
            anim.SetBool("HasBlade", false);
            anim.SetBool("HasUmbrella", false);
            anim.SetBool("HasPan", false);
            anim.SetBool("HasAxe", false);
            HasWeapon = false;
            Unarmed = true;
        }
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

        if (Sign == true || LightBlade == true || Umbrella == true || Pan == true || Microsoft == true)
        {
            anim.SetBool("HasAxe", false);
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
            Damage = 5;
            Durability = 16;
            Microsoft = false;
            LightBlade = false;
            Umbrella = false;
            Pan = false;
            Axe = false;
            anim.SetBool("HasSign", true);
            anim.SetBool("HasWeapon", true);
            if (Durability <= 0)
            {
                anim.SetBool("HasWeapon", false);
                anim.SetBool("HasSign", false);
            }
        }
    }
    public void MicrosoftFun()
    {
        if(Pant.score >= 100)
        {
            Microsoft = true;
        }   
        if (Microsoft == true)
        {
            Damage = 500;
            Durability = 8;
            Pant.score -= 70;
            LightBlade = false;
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            anim.SetBool("HasSign", false);
            anim.SetBool("HasAxe", false);
            anim.SetBool("HasEdge", true);
            anim.SetBool("HasWeapon", true);
            if (Durability <= 0)
            {
                anim.SetBool("HasWeapon", false);
                anim.SetBool("HasEdge", false);
            }
        }
    }
    public void LightBladeFun()
    {
        if(Pant.score >= 50)
        {
            Damage = 25;
            LightBlade = true;
        }
       
        if (LightBlade == true)
        {
            Durability = 12;
            Pant.score -= 50;
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            anim.SetBool("HasSign", false);
            anim.SetBool("HasAxe", false);
            anim.SetBool("HasEdge", false);
            anim.SetBool("HasBlade", true);
            anim.SetBool("HasWeapon", true);
            if (Durability <= 0)
            {
                anim.SetBool("HasWeapon", false);
                anim.SetBool("HasBlade", false);
            }
        }
    }
    public void UmbrellaFun()
    {
        if(Pant.score >= 999999999)
        Umbrella = true;
        if (Umbrella == true)
        {
            Durability = 12;
            Pant.score -= 99999999;
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            anim.SetBool("HasUmbrella", true);
            anim.SetBool("HasWeapon", true);
            if (Durability <= 0)
            {
                anim.SetBool("HasWeapon", false);
                anim.SetBool("HasUmbrella", false);
            }
        }
    }
    public void AxeFun()
    {
        if(Pant.score >= 15)
        {
            Axe = true;
        }
       
        if (Axe == true)
        {
            Damage = 10;
            Durability = 14;
            Pant.score -= 15;
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Pan = false;
            Umbrella = false;
            anim.SetBool("HasEdge", false);
            anim.SetBool("HasSign", false);
            anim.SetBool("HasEdge", false);
            anim.SetBool("HasAxe", true);
            anim.SetBool("HasWeapon", true);
            if (Durability <= 0)
            {
                anim.SetBool("HasWeapon", false);
                anim.SetBool("HasAxe", false);
            }
        }
    }
    public void PanFun()
    {
        Pan = true;
        if (Pan == true)
        {
            Damage = 15;
            Durability = 10;
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Axe = false;
            Umbrella = false;
            anim.SetBool("HasSign", false);
            anim.SetBool("HasAxe", false);
            anim.SetBool("HasEdge", false);
            anim.SetBool("HasPan", true);
            anim.SetBool("HasWeapon", true);
            if (Durability <= 0)
            {
                anim.SetBool("HasWeapon", false);
                anim.SetBool("HasPan", false);
            }
        }
    }
}
