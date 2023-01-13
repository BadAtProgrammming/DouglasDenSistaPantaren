using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HpUi : MonoBehaviour
{
    PlayerHelth Health;

    [SerializeField] TextMeshProUGUI HpControle;

    // Start is called before the first frame update
    void Start()
    {
        Health = FindObjectOfType<PlayerHelth>();
    }
    // Update is called once per frame
    void Update()
    {
        HpControle.text = "HP: " + Health.Health;
    }
}
