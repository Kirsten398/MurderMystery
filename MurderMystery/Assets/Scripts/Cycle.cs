using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cycle : MonoBehaviour
{
    bool Day;
    GameObject AssetButton;
    float Night = 120;
    float NightTime = 0;
    float FastForward = 1;

	// Use this for initialization
	void Start () {
        Day = true;
        AssetButton = GameObject.Find("Asset Tab");
	}
	
	// Update is called once per frame
	void Update () {

        if (!Day)
        {
            AssetButton.SetActive(false);
            NightTime += (Time.deltaTime / Night) * FastForward;

            if(NightTime >= 1)
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
    }
}
