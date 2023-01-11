using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]
    public float playerSpeed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position = transform.position += transform.right * playerSpeed * Time.deltaTime;

        }

        if (Input.GetKey("a"))
        {
            transform.position = transform.position -= transform.right * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            transform.position = transform.position += transform.up * playerSpeed * Time.deltaTime;

        }

        if (Input.GetKey("s"))
        {
            transform.position = transform.position -= transform.up * playerSpeed * Time.deltaTime;

        }
    }
}
