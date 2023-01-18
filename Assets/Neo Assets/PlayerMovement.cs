using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement :MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
     void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("IsWalking", false);
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
    public bool canDown = true;
    public bool canUp = true;
    public bool canLeft = true;
    public bool canRight = true;
    #endregion
    // Update is called once per frame
   
    void Update()
    {
        if (Input.GetKey("d") && canRight == true) //movement
        {
            transform.position = transform.position += transform.right * playerSpeed * Time.deltaTime;
            transform.localScale = new Vector2(4,4 );
            
        }
       
        if (Input.GetKey("a") && canLeft == true)
        {
            transform.position = transform.position -= transform.right * playerSpeed * Time.deltaTime;
            transform.localScale = new Vector2(-4,4 );
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
        #endregion

        
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }


    }

}


