using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    PlayerHelth Health;
    PlayerMovement playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = FindObjectOfType<PlayerMovement>();
    }
    private void Awake()
    {
        Health = FindObjectOfType<PlayerHelth>();
    }

    [SerializeField] //g�r denna alltid 3 h�gre �n player border
    public int leftCBorder;
    [SerializeField]
    int rightCBorder;

    bool canCLeft = true;
    bool canCRight = true;

    // Update is called once per frame
    void Update()
    {
      if(Health.stunned == false) //if not stunned character can move - benjamin
      { 
        if (Input.GetKey("d") && canCRight == true) // camera movement - daniel
        {
            transform.position = transform.position += transform.right * playerSpeed.playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") && canCLeft == true)
        {
            transform.position = transform.position -= transform.right * playerSpeed.playerSpeed * Time.deltaTime;
        }
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
