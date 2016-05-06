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
    float space = 0.75f;

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
            //Random decision of age, 1, 2, and 3 for adult, 4 for child
            age = Random.Range(1, 7);

            if (age < 6)
            {
                Line.Add(Instantiate(woman).transform);
            }
            else
            {
                Line.Add(Instantiate(child).transform);
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
        float personspace = 0.5f;
        int personsRow = 5;
        Line.RemoveAt(0);
        Line.TrimExcess();
        //Camlin use this to make the line move
    }
}
