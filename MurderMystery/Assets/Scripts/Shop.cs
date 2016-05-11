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
    public Business ok;

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

    //purchase Items
    public void purchaseItem(int i)
    {
        if (ok.Money1 > aval[i].purchase())
        {
            ok.makePurchase(aval[i]);
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
                        op.Create(entries[0], System.Int32.Parse(entries[1]), System.Single.Parse(entries[2]), System.Single.Parse(entries[3]), System.Single.Parse(entries[4]), System.Int32.Parse(entries[5]));
                        House_feature hue = Instantiate<House_feature>(op);
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
            return;
        }
    }
    public List<House_feature> getAvailable()
    {
        return availableItems;
    }
}
