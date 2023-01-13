using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PantScore : MonoBehaviour
{
    [SerializeField]
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pant")
        {
            score += 1;
        }
    }
}
