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

        
}
