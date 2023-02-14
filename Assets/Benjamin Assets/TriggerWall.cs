using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    public CameraMovement CameraMovement;
    public PlayerMovement player;
    public int newBorder;
    public int newLeftC;
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.tag == "player")
        {

            player.leftBorder = newBorder;
            CameraMovement.leftCBorder = newLeftC;
        }
    }
    //This script check if player is in collision with object, if touched changes camera and border int values. Only left ones becaus you move to the right. duh.
        
}
