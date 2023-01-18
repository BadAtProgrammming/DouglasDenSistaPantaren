using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathInsults : MonoBehaviour
{
    GameObject splashtext;
    //Ok i made an array -Dev
    string[] insults = { "Have you considered to block, parry and dodge?", "Skill issue", "Bro you suck", "Bad ending", "L", "You sweat games and you still lose?", "Uninstall", "My guy go back to atari", "Your finger slipped right?", "According to my statistics, you suck!", "RDMRDMRDMRDMRDMRDMRDMRDM", "Cope", "Stage 1: Denial", "1v1 me rn bro!!!!!1!", "You should stop playing Dating Sims" };

    GameObject thesplashtext;
    Text splashText;
    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Define and shit -Dev
        thesplashtext = GameObject.Find("Splash");
        splashText = thesplashtext.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Timer you idiot -Dev
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            int currentinsult = Random.Range(0, 15);
            splashText.text = insults[currentinsult];
            timer = 5f;
        }
        ;
    }
}
