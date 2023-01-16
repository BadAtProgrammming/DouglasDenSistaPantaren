using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TooltipMg : MonoBehaviour
{
    string[] Names = {"Sign", "Axe", "Frying Pan", "LightSaber", "Microsoft Edge", "Umbrella" };
    string[] typeitems = {"Blunt", "Axe Body Spray", "Scout TF2", "luminescent plasma blade", "Blade", "Umbrella" };
    string[] costs = {"Free Bruh", "46", "60", "100", "64", "30" };
    string[] descs = { "This is a sign from god, that you should just shut the fuck up. No but really shut up!  Anyways this weapon is a basic weapon, stop crying that its underpowered, you are basically hitting people with a wooden board.", "BONK BONK BONK -Scout TF2 This item is also very effective if you are fighting sans and need extra health. No sans is not in this game, play undertale if you want sans.", "CTRL C + CTRL V description from wikipedia. Source: I made it the fuck up.  What this is though is a laser blade thing that cuts people, thats it.", "This item is very special, as it is the only item with a !!SPECIAL!! ability that finishes the game immediately, it is activated by pressing ALT + F4. You should try it!", "This item shields you from water, but also from enemies apparently, yeah i know its an umbrella, its very effective though." };
    string[] statistics = {"10 Dmg", "20-50", "15 Dmg", "30 Dmg", "25 Dmg", "15 Dmg"};

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
