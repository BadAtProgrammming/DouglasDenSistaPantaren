using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//By Sixten
public class PantScore : MonoBehaviour
{
    public AudioSource pantAdio;//Refrenses the audio surce for the "Pant" sfx -Sixten
    
   [SerializeField] Text ScoreText;//refrenses the score text -Sixten
    
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Pant:" + score;//Makes the score text desplay the score -Sixten
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pant"))//you get 1 "Pant" when you pick up the can -Sixten
        {
            score += 1;
            pantAdio.Play();
        }
        if (collision.CompareTag("Pant2"))//you get 2 "Pant" when you pick up the 1 liter bottle -Sixten
        {
            score += 2;
            pantAdio.Play();
        }
        if (collision.CompareTag("MegusPantus"))
        {
            score = 666;
        }
        //When you pick up diffrent "pant" you get different amounts of points and a sound is playd  
    }
}
