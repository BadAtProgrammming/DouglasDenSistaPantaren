using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponState : MonoBehaviour
{
    bool Test = false;
    private enum PState
    {
        Initial,
        CheckWeapon,
        Attack,
        Break
    }
    private PState _weaponstate;

    private void Update() //TBA code for the weapon system.
    {
        if (_weaponstate == PState.Initial)
        {
            print("Initial");
            _weaponstate = PState.CheckWeapon;
        }
        if (_weaponstate == PState.CheckWeapon)
        {
            DYHWeapon();
            if(Test == true)
            {
                Test = false;
            }
        }
        if (_weaponstate == PState.Attack)
        {
            
        }
        if (_weaponstate == PState.Break)
        {

        }
        void DYHWeapon()
        {
            Test = true;
        }

    }

    
}

    
