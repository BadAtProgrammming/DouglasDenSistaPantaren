using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement :MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    [SerializeField]
    public float playerSpeed;
    #region
    [SerializeField]
    float UpBorder;
    [SerializeField]
    float DownBorder;
    [SerializeField]
    int leftBorder;
    [SerializeField]
    int rightBorder;
    #endregion
    #region
    bool canDown = true;
    bool canUp = true;
    bool canLeft = true;
    bool canRight = true;
    #endregion
    // Update is called once per frame
   
    void Update()
    {
        
        if (Input.GetKey("d") && canRight == true) //movement
        {
            transform.position = transform.position += transform.right * playerSpeed * Time.deltaTime;
            transform.localScale = new Vector2(1,3 );
        }
       
        if (Input.GetKey("a") && canLeft == true)
        {
            transform.position = transform.position -= transform.right * playerSpeed * Time.deltaTime;
            transform.localScale = new Vector2(-1,3 );
        }
        
        if (Input.GetKey("w") && canUp == true)
        {
            transform.position = transform.position += transform.up * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") && canDown == true)
        {
            transform.position = transform.position -= transform.up * playerSpeed * Time.deltaTime;
        }

        #region
        if (transform.position.y <= DownBorder) //gör så karaktären kan inte gå out of bounds
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
        #endregion
    }
}

