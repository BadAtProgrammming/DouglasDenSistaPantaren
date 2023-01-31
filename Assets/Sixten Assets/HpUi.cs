using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpUi : MonoBehaviour
{
    GameObject Playerobject;
    PlayerHelth HealthUi;

    [SerializeField] Text HpControle;

    // Start is called before the first frame update
    void Start()
    {
        HpControle.color = new Color(1, 1, 1, 1);
        Playerobject = GameObject.Find("Health Maneger");
        HealthUi = Playerobject.GetComponent<PlayerHelth>();
    }
    // Update is called once per frame
    void Update()
    {
        HpControle.text = "HP: " + HealthUi.Health;
        if (HealthUi.Health <= 30)
        {
            HpControle.color = new Color(1, 0, 0, 1);
        }
    }
}
