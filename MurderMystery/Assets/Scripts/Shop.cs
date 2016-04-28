using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop : MonoBehaviour {
    List<House_feature> availableItems;
    House_feature[] aval;
    Parser p = new Parser();
	
    // Use this for initialization
    //Unity is screaming about something in here
	void Start () {
        availableItems = p.getShop("Feature_List.muda");
        Debug.Log(availableItems.Count);
        aval = new House_feature[availableItems.Count];
        aval = availableItems.ToArray();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    //Zombie
    public void purchaseZombie(Business ok)
    {
        if (ok.Money1 > aval[0].purchase())
        {
            ok.makePurchase(aval[0]);
        }
    }

    //Jack
    public void purchaseJack(Business ok)
    {
        if (ok.Money1 > aval[1].purchase())
        {
            ok.makePurchase(aval[1]);
        }
    }

    //Ghost
    public void purchaseGhost(Business ok)
    {
        if (ok.Money1 > aval[2].purchase())
        {
            ok.makePurchase(aval[2]);
        }
    }

    //Witch
    public void purchaseWitch(Business ok)
    {
        if (ok.Money1 > aval[3].purchase())
        {
            ok.makePurchase(aval[3]);
        }
    }

    //Vamp
    public void purchaseVamp(Business ok)
    {
        if (ok.Money1 > aval[4].purchase())
        {
            ok.makePurchase(aval[4]);
        }
    }

    //Wolf
    public void purchaseWolf(Business ok)
    {
        if (ok.Money1 > aval[5].purchase())
        {
            ok.makePurchase(aval[5]);
        }
    }

    //Cat
    public void purchaseCat(Business ok)
    {
        if (ok.Money1 > aval[6].purchase())
        {
            ok.makePurchase(aval[6]);
        }
    }

    //Spider
    public void purchaseSpider(Business ok)
    {
        if (ok.Money1 > aval[7].purchase())
        {
            ok.makePurchase(aval[7]);
        }
    }

    //Web
    public void purchaseWeb(Business ok)
    {
        if (ok.Money1 > aval[8].purchase())
        {
            ok.makePurchase(aval[8]);
        }
    }

    //THIS
    public void purchaseTHIS(Business ok)
    {
        if (ok.Money1 > aval[9].purchase())
        {
            ok.makePurchase(aval[9]);
        }
    }
}
