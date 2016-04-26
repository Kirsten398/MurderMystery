using UnityEngine;
using System.Collections;

public class Business : MonoBehaviour {
    string owner;
    bool male;
    private int Money; //Available budget in fictional currency
    float scary; //value between 1 and 20 on how scary the house is
    float happiness; //value between 0 and 5 on how happy your customers are
    float satisfaction; //value between 0 and 10 on the chance of customers returning
    float popularity; //value between 0 and 10 on the chance of getting new customers
    float speed; //value between 1 and 20 on how fast and efficient your house is
    int customers; //number of customers on one day
    int maxAssets; //number of features you can place in your house

    public int Money1
    {
        get
        {
            return Money;
        }

        set
        {
            Money = value;
        }
    }

    public float Scary
    {
        get
        {
            return scary;
        }

        set
        {
            scary = value;
        }
    }

    public float Happiness
    {
        get
        {
            return happiness;
        }

        set
        {
            happiness = value;
        }
    }

    public float Satisfaction
    {
        get
        {
            return satisfaction;
        }

        set
        {
            satisfaction = value;
        }
    }

    public float Popularity
    {
        get
        {
            return popularity;
        }

        set
        {
            popularity = value;
        }
    }

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public int Customers
    {
        get
        {
            return customers;
        }

        set
        {
            customers = value;
        }
    }

    public int MaxAssets
    {
        get
        {
            return maxAssets;
        }

        set
        {
            maxAssets = value;
        }
    }

    void Start () {
        Money = 0;
        owner = "Vlad";
        male = true;
        scary = 1.0f;
        Happiness = 0.5f;
        Satisfaction = 1.0f;
        Popularity = 0.1f;
        Customers = 0;
        Speed = 1;
        MaxAssets = 10;
	}

	// Update is called once per frame
	void Update () {

	}
  void makePurchase(House_feature d){
    if(Money >= d.purchase()) Money -= d.purchase();
    else{} //produce error message
  }
}
