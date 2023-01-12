using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHelth : MonoBehaviour
{
    public TextMeshProUGUI DeathCanvas;
    [SerializeField]
    public int Health;
    // Start is called before the first frame update
    void Start()
    {
        DeathCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            DeathCanvas.enabled = true;
        }
    }
}
