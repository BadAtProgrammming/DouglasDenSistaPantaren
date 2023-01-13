using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PantScore : MonoBehaviour
{
    TextMeshProUGUI ScoreText;

    [SerializeField]
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Pant: " + score;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pant"))
        {
            score += 1;
        }
        if (collision.CompareTag("Pant2"))
        {
            score += 2;
        }
    }
}
