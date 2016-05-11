using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Cycle : MonoBehaviour
{
    bool Day;
    GameObject AssetButton;
    GameObject ManPane;

    float Night = 120;
    float NightTime = 0;
    float FastForward = 1;

    float lineTime = 5;
    float lineShift = 0;

    int lineLength;
    int age;
    public int price = 5;
    string STprice;
    Text priceText;
    public Business biz;
    public GameObject woman;
    public GameObject child;
    public Collider exit;

    List<Transform> Line;
    float space = 0.75f;

    bool Empty;
    bool Closed;

    float nativeWidth = 1920;
    float nativeHeight = 1080;

    // Use this for initialization
    void Start()
    {

        Day = true;
        Empty = false;
        AssetButton = GameObject.Find("Asset Tab");
        Line = new List<Transform>();

        ManPane = GameObject.Find("Management Pane");

        GameObject printPrice = new GameObject("Price");
        printPrice.transform.SetParent(ManPane.transform);
        priceText = printPrice.AddComponent<Text>();
        priceText.transform.position = ManPane.transform.position;
        priceText.transform.position += new Vector3(0, 210, 0);

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        priceText.font = ArialFont;
        priceText.material = ArialFont.material;
        priceText.fontSize = 25;
        priceText.color = Color.black;
        priceText.alignment = (TextAnchor)TextAlignment.Center;
        

        priceText.text = "5";
    }

    // Update is called once per frame
    void Update()
    {
        STprice = "" + price;

        priceText.text = STprice;

        if (!Day)
        {
            AssetButton.SetActive(false);
            NightTime += (Time.deltaTime / Night) * FastForward;

            Empty = true;                

            if (Empty)
            {
                lineShift += (Time.deltaTime / lineTime);

                if (lineShift >= 1 && Line.Count > 0)
                {
                    ShiftLine();
                    biz.GetComponent<Business>().purchaseTicket();

                    lineShift = 0;
                }

                Empty = false;
                
            }

            if (NightTime >= 1)
            {
                Day = true;
                AssetButton.SetActive(true);
                NightTime = 0;
            }
        }
    }

    public void StartDay()
    {
        Day = false;

        //Random Line length between 3 and 5
        lineLength = Random.Range(3, 6);
        
        //Create the line of customers
        for (int i = 0; i < lineLength; i++)
        {
            //Random decision of age, 1, 2, and 3 for adult, 4 for child
            age = Random.Range(1, 7);

            if (age < 6)
            {
                //Randomize these stats
                float pat = Random.Range(5.0f, 10.0f);
                float san = Random.Range(1.0f, 5.0f);
                float stam = Random.Range(1.0f, 10.0f);
                float reas = Random.Range(0.5f, 1.0f);

                //Instantiate model with transform and construct customer
                GameObject ok = Instantiate(woman);
                ok.AddComponent<Customer>();
                ok.GetComponent<Customer>().createCustomer("Kirsten", false, true, pat, san, stam, reas);

                //Add to line
                Line.Add(ok.transform);
            }
            else
            {
                //Randomize these stats
                float pat = Random.Range(1.0f, 5.0f);
                float san = Random.Range(5.0f, 10.0f);
                float stam = Random.Range(1.0f, 10.0f);
                float reas = Random.Range(0.1f, 0.5f);

                //Instantiate model with transform and construct customer
                GameObject ko = Instantiate(child);
                ko.AddComponent<Customer>();
                ko.GetComponent<Customer>().createCustomer("Aria", false, false, pat, san, stam, reas);

                //Add to Line
                Line.Add(ko.transform);
            }
        }

        makeLine();
    }

    void makeLine()
    {
        int pos = 1;

        foreach (Transform t in Line)
        {
            t.transform.position = new Vector3(-2.5f, -0.082f, (-2.82f - pos) * space);

            pos++;
        }
    }

    void ShiftLine()
    {
        Transform[] op = Line.ToArray();

        Destroy(op[0].gameObject);

        for(int i = 1; i < op.Length; i++)
        {
            op[i].Translate(0, 0, space);
        }

        Line.RemoveAt(0);
        //Camlin use this to make the line move
    }

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.CompareTag("Player"))
            Empty = true;
    }

    public void addPrice()
    {
        price += 5;
    }

    public void minusPrice()
    {
        price -= 5;
    }
}
