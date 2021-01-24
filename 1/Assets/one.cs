using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class one : MonoBehaviour
{
    public InputField kidsa;
    public Text Looksa;
    private string one1, two, three, four, five;
    private string number;

    // Start is called before the first frame update
    void Start()
    {
        one1 = "Hi";
        two = "Sawatdee";
        three = "Konnichiwa";
        four = "Annyeonghaseyo";
        five = "nihao";
    }

    // Update is called once per frame
    void Update()
    {
        number = kidsa.text;
    }

    public void wowsaa()
    {
        if (number == one1 || number == two || number == three || number == four || number == five)
        {
            Looksa.text = "[ " + $"<color=purple>{number}</Color>" + " ] " + " is found. ";
        }
        else
        {
            Looksa.text = "[ " + $"<color=pink>{number}</Color>" + " ] " + " is not found. ";
        }
    }





}
