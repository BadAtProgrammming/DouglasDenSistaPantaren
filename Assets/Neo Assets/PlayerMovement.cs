using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] int UpBorder;
    [SerializeField] int DownBorder;

    [SerializeField]
    public float playerSpeed;
    [SerializeField]
    int leftBorder;
    [SerializeField]
    int rightBorder;

    bool canDown = true;
    bool canUp = true;
    bool canLeft = true;
    bool canRight = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && canRight == true) //movement
        {
            transform.position = transform.position += transform.right * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") && canLeft == true)
        {
            transform.position = transform.position -= transform.right * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("w") && canUp == true)
        {
            transform.position = transform.position += transform.up * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") && canDown == true)
        {
            transform.position = transform.position -= transform.up * playerSpeed * Time.deltaTime;
        }


        if (transform.position.y <= DownBorder) //g�r s� karakt�ren kan inte g� out of bounds
            {
            canDown = false;
            }
        else
        {
            canDown = true;
        }

        if (transform.position.y >= UpBorder)
        {
            canUp = false;
        }
        else 
        {
            canUp = true;
        }

        if (transform.position.x <= leftBorder)
        {
            canLeft = false;
        }
        else
        {
            canLeft = true;
        }

        if (transform.position.x >= rightBorder)
        {
            canRight = false;
        }
        else
        {
            canRight = true;
        }
    }
}

