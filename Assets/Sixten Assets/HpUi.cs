using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpUi : MonoBehaviour
{
    GameObject Playerobject;
    PlayerHelth HealthUi;

    [SerializeField] Text HpControle;

    public Color startColor = Color.white;
    public Color endColor = Color.red;
    [Range(0, 10)]
    public float speed = 1;

    Renderer ren;

    void Awake()
    {
        ren = GetComponent<Renderer>();
    }

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
        if (HealthUi.Health <= 30)
        {
            HpControle.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
        }
    }
}
