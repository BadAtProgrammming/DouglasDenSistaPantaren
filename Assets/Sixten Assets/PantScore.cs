using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantScore : MonoBehaviour
{
    public AudioSource pantAdio;
    
   [SerializeField] Text ScoreText;
    
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Pant:" + score;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pant"))
        {
            score += 1;
            pantAdio.Play();
        }
        if (collision.CompareTag("Pant2"))
        {
            score += 2;
            pantAdio.Play();
        }
        if (collision.CompareTag("MegusPantus"))
        {
            score = 666;
        }
    }
}
