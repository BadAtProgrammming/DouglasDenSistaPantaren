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

    [SerializeField] //gör denna alltid 3 högre än player border
    int leftCBorder;
    [SerializeField]
    int rightCBorder;

    bool canCLeft = true;
    bool canCRight = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && canCRight == true)
        {
            transform.position = transform.position += transform.right * playerSpeed.playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") && canCLeft == true)
        {
            transform.position = transform.position -= transform.right * playerSpeed.playerSpeed * Time.deltaTime;
        }


        if (transform.position.x <= leftCBorder)
        {
            canCLeft = false;
        }
        else
        {
            canCLeft = true;
        }

        if (transform.position.x >= rightCBorder)
        {
            canCRight = false;
        }
        else
        {
            canCRight = true;
        }
    }
}
