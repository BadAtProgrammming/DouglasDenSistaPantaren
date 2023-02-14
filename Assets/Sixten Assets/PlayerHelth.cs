using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHelth : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    [SerializeField]
    RectTransform transformobject;
    public int Health;
    float blinkTimer;
    bool shouldBlink;
    SpriteRenderer player;
    public bool stunned = false;


    bool activated = false;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().GetComponent<SpriteRenderer>();
        //References spew out errors nonetheless... I cant fix it for some reason, this is just the best solution -Dev
    }

    void Update()
    {
        if (shouldBlink)
        {
            blinkTimer += Time.deltaTime;
            if (blinkTimer > 0.3)
            {
                player.color = Color.white;
                shouldBlink = false;
                blinkTimer = 0;
            }
        }//makes you flash red when you take damage -Sixten

        //If you have no heath: show death screen -Sixten
        if (Health <= 0 && activated == false)
        {
            //Avoids errors by activating it only once, this makes constantly spewing errors & lagging the game impossible -Dev
            GameObject.Find("player").GetComponent<PlayerMovement>().enabled = false; //disables player movement when health <= 0
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().enabled = false;//disables camera movement when health <= 0
            GameObject.Find("pHurtbox").GetComponent<PlayerTakeDamage>().enabled = false;//You can´t take damage when you are dead -Sixten
            //When health 0 activates the entire canvasobject and its components -Dev
            transformobject.anchoredPosition = new Vector3(640f, 360f, 0f);
            anim.SetInteger("Death", Random.Range(0, 6));
            activated = true;
        }
      
    }
    public void TakeDamage(int amount)//if the player takes damage it flashes red -Sixten
    {
        Health -= amount;
        shouldBlink = true;
        player.color = Color.red;
        StartCoroutine(TakenDamage());
    }

    IEnumerator TakenDamage() //Stuns the player, disables camera and movement -Benjamin
    {
        print("ASS");
        stunned = true;
        yield return new WaitForSeconds(0.2f);
        stunned = false;
        print("PAIN");
    }

}
