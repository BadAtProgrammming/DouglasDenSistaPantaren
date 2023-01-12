using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    PlayerMovement playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = FindObjectOfType<PlayerMovement>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position = transform.position += transform.right * playerSpeed.playerSpeed * Time.deltaTime;

        }

        if (Input.GetKey("a"))
        {
            transform.position = transform.position -= transform.right * playerSpeed.playerSpeed * Time.deltaTime;

        }
    }
}
