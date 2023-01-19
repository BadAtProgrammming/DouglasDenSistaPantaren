using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HpUi : MonoBehaviour
{
    GameObject Playerobject;
    PlayerHelth HealthUi;

    [SerializeField] TextMeshProUGUI HpControle;

    // Start is called before the first frame update
    void Start()
    {
        Playerobject = GameObject.Find("Health Maneger");
        HealthUi = Playerobject.GetComponent<PlayerHelth>();
    }
    // Update is called once per frame
    void Update()
    {
        HpControle.text = "HP: " + HealthUi.Health;
    }
}
