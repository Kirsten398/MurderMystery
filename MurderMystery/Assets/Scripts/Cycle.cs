using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Cycle : MonoBehaviour
{
    bool Day;
    GameObject AssetButton;
    float Night = 120;
    float NightTime = 0;
    float FastForward = 1;
    int lineLength;
    int age;
    public GameObject woman;
    public GameObject child;
    public Collider exit;

    List<Transform> Line;
    float space = 0.75f;

    bool Empty;
    bool Closed;

    // Use this for initialization
    void Start()
    {
        Day = true;
        Empty = false;
        AssetButton = GameObject.Find("Asset Tab");
        Line = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Day)
        {
            AssetButton.SetActive(false);
            NightTime += (Time.deltaTime / Night) * FastForward;

            if (NightTime == 1 / 8)
            {
                Empty = true;                
            }

            if (Empty)
            {
                ShiftLine();
                Empty = false;
            }

            OnCollisionEnter();

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
                Transform ok = Instantiate(woman).transform;
                ok.GetComponent<Customer>().createCustomer("Kirsten", false, true, pat, san, stam, reas);

                //Add to line
                Line.Add(ok);
            }
            else
            {
                //Randomize these stats
                float pat = Random.Range(1.0f, 5.0f);
                float san = Random.Range(5.0f, 10.0f);
                float stam = Random.Range(1.0f, 10.0f);
                float reas = Random.Range(0.1f, 0.5f);

                //Instantiate model with transform and construct customer
                Transform ok = Instantiate(child).transform;
                ok.GetComponent<Customer>().createCustomer("Aria", false, false, pat, san, stam, reas);

                //Add to Line
                Line.Add(ok);
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
        List<Transform> temp = Line;
        Line.RemoveAt(0);
        Line.TrimExcess();
        Transform[] op = Line.ToArray();

        for(int i = 0; i < op.Length;i++)
        {
            op[i].position = temp[i].position;
        }

        //Camlin use this to make the line move
    }

    void OnCollisionEnter()
    {
        if(exit)
            Empty = true;
    }
}
