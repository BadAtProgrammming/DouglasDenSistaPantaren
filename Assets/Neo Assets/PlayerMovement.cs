using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement :MonoBehaviour
{
    PlayerHelth health;
    Animator anim;
    public bool IsWalking;
    // Start is called before the first frame update
     void Start()
    {
        health = GetComponent<PlayerHelth>();
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
    public int leftBorder;
    [SerializeField]
    public int rightBorder;
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
            transform.localScale = new Vector2(3.5f,3.5f );
            
        }
       
        if (Input.GetKey("a") && canLeft == true)
        {
            transform.position = transform.position -= transform.right * playerSpeed * Time.deltaTime;
            transform.localScale = new Vector2(-3.5f,3.5f );
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

        
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            anim.SetBool("IsWalking", true);
            IsWalking = true;
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
        if (health.TakenDamage == true)
        {
            TakenDamage();
        }

    }
    
    void TakenDamage()
    {
        HitStunTimer();
    }
    IEnumerator HitStunTimer()
    {
        yield return new WaitForSeconds(0.2f);
    }
        
    
}


