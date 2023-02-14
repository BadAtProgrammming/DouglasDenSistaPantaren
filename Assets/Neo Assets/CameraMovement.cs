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

    [SerializeField] //gör denna alltid 3 högre än player border
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
        if (Input.GetKey("d") && canCRight == true)//Makes the camera move right -Sixten
        {
            transform.position = transform.position += transform.right * playerSpeed.playerSpeed * Time.deltaTime;
            }
        if (Input.GetKey("a") && canCLeft == true)//Makes the camera move left -Sixten
            {
            transform.position = transform.position -= transform.right * playerSpeed.playerSpeed * Time.deltaTime;
        }
      }


        if (transform.position.x <= leftCBorder)//the camrea can't move past the left camera border -Sixten
        {
            canCLeft = false;
        }
        else
        {
            canCLeft = true;
        }

        if (transform.position.x >= rightCBorder)//the camrea can't move past the right camera border -Sixten
        {
            canCRight = false;
        }
        else
        {
            canCRight = true;
        }
    }
}
