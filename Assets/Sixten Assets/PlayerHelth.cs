using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHelth : MonoBehaviour
{
    [SerializeField]
    public int Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {

        }
    }
}
