using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHelth : MonoBehaviour
{
    Animator anim;
    [SerializeField]
    RectTransform transformobject;
    public int Health;
    

    bool activated = false;

    void Start()
    {
        //References spew out errors nonetheless... I cant fix it for some reason, this is just the best solution -Dev
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        //If you have no heath: show death screen -Sixten
        if (Health <= 0 && activated == false)
        {
            anim.SetInteger("Death", Random.Range(0, 6));
            //Avoids errors by activating it only once, this makes constantly spewing errors & lagging the game impossible -Dev
            GameObject.Find("player").GetComponent<PlayerMovement>().enabled = false; //disables player movement when health <= 0
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().enabled = false;//disables camera movement when health <= 0
            GameObject.Find("pHurtbox").GetComponent<PlayerTakeDamage>().enabled = false;
            //When health 0 activates the entire canvasobject and its components -Dev
            transformobject.anchoredPosition = new Vector3(640f, 360f, 0f);
            activated = true;
        }
    }
    public void TakeDamage(int amount)
    {
        Health -= amount;
    }
}
