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

    List<Transform> Line;

    // Use this for initialization
    void Start()
    {
        Day = true;
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
            //Random decision of age, 1 for adult, 2 for child
            age = Random.Range(1, 3);

            if (age == 1)
            {
                Instantiate(woman);
                Line.Add(woman.transform);
            }
            else
            {
                Instantiate(child);
                Line.Add(child.transform);
            }
        }
    }

    void ShiftLine()
    {
        float personspace = 0.5f;
        int personsRow = 5;
        Line.RemoveAt(0);
        Line.TrimExcess();
        //Camlin use this to make the line move
    }
}
