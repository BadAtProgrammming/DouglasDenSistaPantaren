using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TooltipMg : MonoBehaviour
{
    string[] Names = { };
    string[] typeitems = { };
    string[] costs = { };
    string[] descs = { };
    string[] statistics = { };

    [SerializeField] private CanvasGroup canvasGroup;

    //Make this a speech bubble cuz i didnt make it an array -Dev
    private Image itemimage;
    private GameObject ImageOnCanvas;

    private TextMeshProUGUI Name;
    private GameObject NameCanvas;

    private TextMeshProUGUI ItemType;
    private GameObject ItemTypeCanvas;

    private TextMeshProUGUI Cost;
    private GameObject CostCanvas;

    private TextMeshProUGUI Desc;
    private GameObject DescCanvas;

    private TextMeshProUGUI Stats;
    private GameObject StatCanv;

    void Start()
    {
        //I hate defining shit on fucking god -Dev
        ImageOnCanvas = GameObject.Find("ItemImg");
        itemimage = ImageOnCanvas.GetComponent<Image>();

        NameCanvas = GameObject.Find("Name");
        Name = NameCanvas.GetComponent<TextMeshProUGUI>();

        ItemTypeCanvas = GameObject.Find("Itemtype");
        ItemType = ItemTypeCanvas.GetComponent<TextMeshProUGUI>();

        CostCanvas = GameObject.Find("Cost");
        Cost = CostCanvas.GetComponent<TextMeshProUGUI>();

        DescCanvas = GameObject.Find("Desc");
        Desc = DescCanvas.GetComponent<TextMeshProUGUI>();

        StatCanv = GameObject.Find("Statistics");
        Stats = StatCanv.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }
}
