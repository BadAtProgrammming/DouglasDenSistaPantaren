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
    public bool Sign = false;
    public bool Microsoft = false;
    public bool LightBlade = false;
    public bool Umbrella = false;
    public bool Pan = false;
    public bool Axe = false;
    public EnemyDamageScript Weapondamage;
        void Start()
        {
            Weapondamage = FindObjectOfType<EnemyDamageScript>();
            Sign = true;
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
        }

        if (Microsoft)
        {
            LightBlade = false;
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            Weapondamage.Damage = 999;
        }

        if (LightBlade)
        {
            Umbrella = false;
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            Weapondamage.Damage = 60;
        }

        if (Umbrella)
        {
            Pan = false;
            Axe = false;
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Weapondamage.Damage = 20;
        }

        if (Axe)
        {
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Pan = false;
            Umbrella = false;
            Weapondamage.Damage = 50;
        }

        if (Pan)
        {
            Sign = false;
            Microsoft = false;
            LightBlade = false;
            Axe = false;
            Umbrella = false;
        }
    }
}
