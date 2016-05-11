using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine.UI;

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
    public House myHouse;
    public Shop s;
    public Cycle price;
    Text monies;
    GameObject MP;
    string STmonies;
    string saveFile = "savefile.muda";

    public int Money1 {
        get {
            return Money;
        }

        set {
            Money = value;
        }
    }

    public float Scary {
        get {
            return scary;
        }

        set {
            scary = value;
        }
    }

    public float Happiness {
        get {
            return happiness;
        }

        set {
            happiness = value;
        }
    }

    public float Satisfaction {
        get {
            return satisfaction;
        }

        set {
            satisfaction = value;
        }
    }

    public float Popularity {
        get {
            return popularity;
        }

        set {
            popularity = value;
        }
    }

    public float Speed {
        get {
            return speed;
        }

        set {
            speed = value;
        }
    }

    public int Customers {
        get {
            return customers;
        }

        set {
            customers = value;
        }
    }

    public int MaxAssets {
        get {
            return maxAssets;
        }

        set {
            maxAssets = value;
        }
    }

    void Start () {
        Money = 500;
        owner = "Vlad";
        male = true;
        scary = 1.0f;
        Happiness = 0.5f;
        Satisfaction = 1.0f;
        Popularity = 0.1f;
        Customers = 0;
        Speed = 1;
        MaxAssets = 10;

        MP = GameObject.Find("Management Pane");

        GameObject printMoney = new GameObject("Money");
        printMoney.transform.SetParent(MP.transform);
        monies = printMoney.AddComponent<Text>();
        monies.transform.position = MP.transform.position;
        monies.transform.position += new Vector3(50, 125, 0);

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        monies.font = ArialFont;
        monies.material = ArialFont.material;
        monies.fontSize = 25;
        monies.color = Color.black;
        monies.alignment = (TextAnchor)TextAlignment.Center;

        monies.text = "500";
    }

	// Update is called once per frame
	void Update () {
        STmonies = "" + Money;

        monies.text = STmonies;
	}
    public void makePurchase(House_feature d)
    {
        if (Money >= d.purchase())
        {
            Money -= d.purchase();
            myHouse.AddAsset(d);
        }
        else { } //produce error message
    }

    public void purchaseTicket()
    {
        Money += price.GetComponent<Cycle>().price;
    }

    public void loadGame(string fileName)
    {
        // Handle any problems that might arise when reading the text
        try
        {
            string line;
            StreamReader theReader = new StreamReader(fileName, Encoding.Default);
            int i = 0;
            using (theReader)
            {
                line = theReader.ReadLine();

                if (line != null)
                {
                    do
                    {
                        string[] entries = line.Split('|');
                        if (i == 0)
                        {
                            owner = entries[0];
                            if (System.Int32.Parse(entries[1]) == 0) male = false; else male = true;
                            Money = (int)long.Parse(entries[2]);
                            Popularity = System.Single.Parse(entries[3]);
                            Speed = System.Single.Parse(entries[4]);
                        }
                        else
                        {
                            for(int j = 0; j < entries.Length; j++)
                            {
                                int ammount = System.Int16.Parse(entries[j]);
                                for(int k = 0; k< ammount; k++)
                                {
                                    myHouse.AddAsset(s.getAvailable()[j]);
                                }
                            }
                        }
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

    public void SaveGame(string filename)
    {
        int m = 0;
        if (male) m = 1;
        string yip = "";
        for(int i = 0; i < myHouse.vals().Count; i++)
        {
            yip += myHouse.vals()[i] + "|";
            if (i!=myHouse.vals().Count-1)
            yip += "|";
        }
        string[] lines = { owner + "|" + m + "|" + Money + "|" + popularity + "|" + speed,yip};
        File.WriteAllLines(filename, lines);
    }

    public void NewGame()
    {
        Application.LoadLevel("Test");
    }
}
