using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//By Sixten
public class PantScript : MonoBehaviour
{
   
    public float amplitude = 0.25f; //how far the "pant" bobs up and down -Sixten
    public float frequency = 1f;//how fast the "pant" bobs up and down -Sixten

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
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude; //makes the "pant" bob up and down like in minecraft -Sixten

        transform.position = tempPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player") || collision.CompareTag("PlayerAttackbox"))//if the player walks into the "Pant" the "Pant" gets destroid -Sixten
        {
            Destroy(gameObject);
        }
    }
}
