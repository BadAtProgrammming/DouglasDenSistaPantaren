using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantScript : MonoBehaviour
{
   
    public float amplitude = 0.25f;
    public float frequency = 1f;

    // Position Storage Variables
    Vector2 posOffset = new Vector2();
    Vector2 tempPos = new Vector2();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player") || collision.CompareTag("PlayerAttackbox"))
        {
            Destroy(gameObject);
        }
    }
}
