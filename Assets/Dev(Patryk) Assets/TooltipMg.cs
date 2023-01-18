using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TooltipMg : MonoBehaviour
{
    //I LOVE ARRAYS I LOVE ARRAYS I LOVE ARRAYS I LOVE ARRAYS -dev
    string[] Names = {"Sign", "Axe", "Frying Pan", "LightSaber", "Microsoft Edge", "Umbrella" };
    string[] typeitems = {"Blunt", "Axe Body Spray", "Scout TF2", "luminescent plasma blade", "Blade", "Umbrella" };
    string[] costs = {"Free Bruh", "Cost: 46", "Cost: 60", "Cost: 100", "Cost: 64", "Cost: 30" };
    string[] descs = {"This is a sign... that you should beat everyone up!  Anyways this weapon is a basic weapon, stop crying that its underpowered, you are basically hitting people with a wooden board.","Axe Body spray, this is basically an axe, feel like the american psycho yet?", "BONK BONK BONK -Scout TF2 This item is also very effective if you are fighting sans and need extra health. No sans is not in this game, play undertale if you want sans.", "CTRL C + CTRL V description from wikipedia. Source: I made it the fuck up.  What this is though is a laser blade thing that cuts people, thats it.", "This item is very special, as it is the only item with a !!SPECIAL!! ability that finishes the game immediately, it is activated by pressing ALT + F4. You should try it!", "This item shields you from water, but also from enemies apparently, yeah i know its an umbrella, its very effective though." };
    string[] statistics = {"10 Dmg", "20-50", "15 Dmg", "30 Dmg", "25 Dmg", "15 Dmg"};

    [SerializeField] private CanvasGroup canvasGroup;

    //Make this a speech bubble cuz i didnt make it an array -Dev
    private Image itemimage;
    private GameObject ImageOnCanvas;

    private Text Name;
    private GameObject NameCanvas;

    private Text ItemType;
    private GameObject ItemTypeCanvas;

    private Text Cost;
    private GameObject CostCanvas;

    private Text Desc;
    private GameObject DescCanvas;

    private Text Stats;
    private GameObject StatCanv;

    [SerializeField]
    public int localitemused;

    void Start()
    {
        //I hate defining shit on fucking god -Dev
        ImageOnCanvas = GameObject.Find("ItemImg");
        itemimage = ImageOnCanvas.GetComponent<Image>();

        NameCanvas = GameObject.Find("Name");
        Name = NameCanvas.GetComponent<Text>();

        ItemTypeCanvas = GameObject.Find("Itemtype");
        ItemType = ItemTypeCanvas.GetComponent<Text>();

        CostCanvas = GameObject.Find("Cost");
        Cost = CostCanvas.GetComponent<Text>();

        DescCanvas = GameObject.Find("Desc");
        Desc = DescCanvas.GetComponent<Text>();

        StatCanv = GameObject.Find("Statistics");
        Stats = StatCanv.GetComponent<Text>();
    }

    void Update()
    {
        //Automatically changes text depending on what you are buying
        Name.text = Names[localitemused];
        ItemType.text = typeitems[localitemused];
        Cost.text = costs[localitemused];
        Desc.text = descs[localitemused];
        Stats.text = statistics[localitemused];
    }
}
