using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorWeapon : MonoBehaviour
{
    Animator anim;
    private Attacks attacks;
    private Weapons weapons;
    private PlayerMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        attacks = GetComponent<Attacks>();
        weapons = GetComponent<Weapons>();
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (weapons.HasWeapon == true && movement.IsWalking == true)
        {
            anim.SetBool("HasWeaponWalking", true);
        }
        else
        {
           anim.SetBool("HasWeaponWalking", false);
        }
        if (weapons.HasWeapon == true && attacks.Swinging == true)
        {
            anim.SetBool("Swinging", true);
        }
        else
        {
            anim.SetBool("Swinging", false);
        }
    }
}
