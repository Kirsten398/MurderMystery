using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class House_feature : MonoBehaviour {
    public string nahme;
    public int cost; //Available budget in fictional currency
    public float scary; //value between 0 and 20 on how scary the prop
    public float happiness; //value between 0 and 5 on how happy your customers get from seeing this
    public float originality; //value between 0 and 1 on how original the prop is
    public int AssetPoints;

    public Business ok;
    List<House_feature> availableItems;
    House_feature[] aval;

    public int AssetPoints1
    {
        get
        {
            return AssetPoints;
        }

        set
        {
            AssetPoints = value;
        }
    }

    void Start () {
        aval = availableItems.ToArray();
    }
    public void Create(string n, int c, float s, float h, float o, int ap)
    {
        nahme = n;
        cost = c;
        scary = s;
        happiness = h;
        originality = o;
        AssetPoints = ap;
    }
	// Update is called once per frame
	void Update () {

	}

    //purchase Items
    public void purchaseItem(int i)
    {
        if (ok.Money1 > aval[i].purchase())
        {
            ok.makePurchase(aval[i]);
        }
    }

    public int purchase(){
        return cost;
  }
}
