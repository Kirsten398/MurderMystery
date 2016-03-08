using UnityEngine;
using System.Collections;

public class Business : MonoBehaviour {
    string owner;
    bool male;
    int Money; //Available budget in fictional currency
    float scary; //value between 1 and 20 on how scary the house is
    float happiness; //value between 0 and 5 on how happy your customers are
    float satisfaction; //value between 0 and 10 on the chance of customers returning
    float popularity; //value between 0 and 10 on the chance of getting new customers
    float speed; //value between 1 and 20 on how fast and efficient your house is
    int customers; //number of customers on one day
    int maxAssets; //number of features you can place in your house
	void Start () {
        Money = 0;
        owner = "Vlad";
        male = true;
        scary = 1.0f;
        happiness = 0.5f;
        satisfaction = 1.0f;
        popularity = 0.1f;
        customers = 0;
        speed = 1;
        maxAssets = 10;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
