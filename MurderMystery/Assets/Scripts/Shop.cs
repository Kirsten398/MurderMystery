using UnityEngine;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Shop : MonoBehaviour {
    List<House_feature> availableItems;
    public Transform hf;
    House_feature op;
    House_feature[] aval;
    string fname;

    // Use this for initialization
    void Start () {
        availableItems = new List<House_feature>();
        op = hf.GetComponent<House_feature>();
        fname = "Feature_List.muda";
        getShop(fname);
        aval = availableItems.ToArray();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void makePurchase(int i)
    {

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
    public void purchaseTHIS(Business ok, int i)
    {
        if (ok.Money1 > aval[9].purchase())
        {
            ok.makePurchase(aval[9]);
        }
    }
    public void getShop(string fileName)
    {
        // Handle any problems that might arise when reading the text
        try
        {
            string line;
            StreamReader theReader = new StreamReader(fileName, Encoding.Default);
            using (theReader)
            {
                line = theReader.ReadLine();
                
                if (line != null)
                {
                    do
                    {
                        string[] entries = line.Split('|');
                        Debug.Log(entries[0]);
                        op.Create(entries[0], System.Int32.Parse(entries[1]), System.Single.Parse(entries[2]), System.Single.Parse(entries[3]), System.Single.Parse(entries[4]), System.Int32.Parse(entries[5]));
                        House_feature hue = Instantiate<House_feature>(op);
                        Debug.Log(hue.nahme);
                        availableItems.Add(hue);
                        if (entries.Length > 0)
                            line = theReader.ReadLine();
                    }
                    while (line != null);
                }
                theReader.Close();
            }
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
            return;
        }
    }
    public List<House_feature> getAvailable()
    {
        return availableItems;
    }
}
