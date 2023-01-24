using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    public PlayerMovement player;
    public int newBorder;
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D collider)
    {
        player.leftBorder = newBorder;
    }

        
}
