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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pant")
        {
            score += 1;
        }
    }
}
