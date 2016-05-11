using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class House : MonoBehaviour {
    List<House_feature> features = new List<House_feature>();
    int maxAssets = 10;
    int totalAssets;
    List<Transform> Line;
    public Shop avalItems;
    List<int> allAssets = new List<int>();

    GameObject HP;
    Text ItemTextZ, ItemTextJ, ItemTextG, ItemTextWi, ItemTextV, ItemTextWo, ItemTextC, ItemTextS, ItemTextWeb, ItemTextT;
    int z, j, g, wi, v, wo, c, s, web, T;
    string stZ, stJ, stG, stWI, stV, stWO, stC, stS, stWEB, STt;

    void Start()
    {
        HP = GameObject.Find("House Pane");
        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        GameObject printItemZ = new GameObject("Item");
        printItemZ.transform.SetParent(HP.transform);
        ItemTextZ = printItemZ.AddComponent<Text>();
        ItemTextZ.transform.position = HP.transform.position;
        ItemTextZ.transform.position += new Vector3(120, 235, 0);

        ItemTextZ.font = ArialFont;
        ItemTextZ.material = ArialFont.material;
        ItemTextZ.fontSize = 25;
        ItemTextZ.color = Color.black;
        ItemTextZ.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextZ.text = "0";

        GameObject printItemJ = new GameObject("Item");
        printItemJ.transform.SetParent(HP.transform);
        ItemTextJ = printItemJ.AddComponent<Text>();
        ItemTextJ.transform.position = HP.transform.position;
        ItemTextJ.transform.position += new Vector3(120, 174, 0);

        ItemTextJ.font = ArialFont;
        ItemTextJ.material = ArialFont.material;
        ItemTextJ.fontSize = 25;
        ItemTextJ.color = Color.black;
        ItemTextJ.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextJ.text = "0";

        GameObject printItemG = new GameObject("Item");
        printItemG.transform.SetParent(HP.transform);
        ItemTextG = printItemG.AddComponent<Text>();
        ItemTextG.transform.position = HP.transform.position;
        ItemTextG.transform.position += new Vector3(120, 113, 0);

        ItemTextG.font = ArialFont;
        ItemTextG.material = ArialFont.material;
        ItemTextG.fontSize = 25;
        ItemTextG.color = Color.black;
        ItemTextG.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextG.text = "0";

        GameObject printItemWi = new GameObject("Item");
        printItemWi.transform.SetParent(HP.transform);
        ItemTextWi = printItemWi.AddComponent<Text>();
        ItemTextWi.transform.position = HP.transform.position;
        ItemTextWi.transform.position += new Vector3(120, 52, 0);

        ItemTextWi.font = ArialFont;
        ItemTextWi.material = ArialFont.material;
        ItemTextWi.fontSize = 25;
        ItemTextWi.color = Color.black;
        ItemTextWi.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextWi.text = "0";

        GameObject printItemV = new GameObject("Item");
        printItemV.transform.SetParent(HP.transform);
        ItemTextV = printItemV.AddComponent<Text>();
        ItemTextV.transform.position = HP.transform.position;
        ItemTextV.transform.position += new Vector3(120, -9, 0);

        ItemTextV.font = ArialFont;
        ItemTextV.material = ArialFont.material;
        ItemTextV.fontSize = 25;
        ItemTextV.color = Color.black;
        ItemTextV.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextZ.text = "0";

        GameObject printItemWo = new GameObject("Item");
        printItemWo.transform.SetParent(HP.transform);
        ItemTextWo = printItemWo.AddComponent<Text>();
        ItemTextWo.transform.position = HP.transform.position;
        ItemTextWo.transform.position += new Vector3(120, -70, 0);

        ItemTextWo.font = ArialFont;
        ItemTextWo.material = ArialFont.material;
        ItemTextWo.fontSize = 25;
        ItemTextWo.color = Color.black;
        ItemTextWo.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextZ.text = "0";

        GameObject printItemC = new GameObject("Item");
        printItemC.transform.SetParent(HP.transform);
        ItemTextC = printItemC.AddComponent<Text>();
        ItemTextC.transform.position = HP.transform.position;
        ItemTextC.transform.position += new Vector3(120, -131, 0);

        ItemTextC.font = ArialFont;
        ItemTextC.material = ArialFont.material;
        ItemTextC.fontSize = 25;
        ItemTextC.color = Color.black;
        ItemTextC.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextC.text = "0";

        GameObject printItemS = new GameObject("Item");
        printItemS.transform.SetParent(HP.transform);
        ItemTextS = printItemS.AddComponent<Text>();
        ItemTextS.transform.position = HP.transform.position;
        ItemTextS.transform.position += new Vector3(120, -192, 0);

        ItemTextS.font = ArialFont;
        ItemTextS.material = ArialFont.material;
        ItemTextS.fontSize = 25;
        ItemTextS.color = Color.black;
        ItemTextS.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextZ.text = "0";

        GameObject printItemWeb = new GameObject("Item");
        printItemWeb.transform.SetParent(HP.transform);
        ItemTextWeb = printItemWeb.AddComponent<Text>();
        ItemTextWeb.transform.position = HP.transform.position;
        ItemTextWeb.transform.position += new Vector3(120, -253, 0);

        ItemTextWeb.font = ArialFont;
        ItemTextWeb.material = ArialFont.material;
        ItemTextWeb.fontSize = 25;
        ItemTextWeb.color = Color.black;
        ItemTextWeb.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextWeb.text = "0";

        GameObject printItemT = new GameObject("Item");
        printItemT.transform.SetParent(HP.transform);
        ItemTextT = printItemT.AddComponent<Text>();
        ItemTextT.transform.position = HP.transform.position;
        ItemTextT.transform.position += new Vector3(120, -310, 0);

        ItemTextT.font = ArialFont;
        ItemTextT.material = ArialFont.material;
        ItemTextT.fontSize = 25;
        ItemTextT.color = Color.black;
        ItemTextT.alignment = (TextAnchor)TextAlignment.Center;

        ItemTextT.text = "0";

        Line = new List<Transform>();
    }
    void Update() {
        allAssets = vals();
        allAssets.ToArray();

        z = allAssets[0];
        stZ = "" + z;
        ItemTextZ.text = stZ;

        j = allAssets[1];
        stJ = "" + j;
        ItemTextJ.text = stJ;

        g = allAssets[2];
        stG = "" + g;
        ItemTextG.text = stG;

        wi = allAssets[3];
        stWI = "" + wi;
        ItemTextWi.text = stWI;

        v = allAssets[4];
        stV = "" + v;
        ItemTextV.text = stV;

        wo = allAssets[5];
        stWO = "" + wo;
        ItemTextWo.text = stWO;

        c = allAssets[6];
        stC = "" + c;
        ItemTextC.text = stC;

        s = allAssets[7];
        stS = "" + s;
        ItemTextS.text = stS;

        web = allAssets[8];
        stWEB = "" + web;
        ItemTextWeb.text = stWEB;

        T = allAssets[9];
        STt = "" + T;
        ItemTextT.text = STt;
    }

    public void AddAsset(House_feature m)
    {
        if (totalAssets + m.AssetPoints1 <= maxAssets)
        {
            features.Add(m);
            totalAssets += m.AssetPoints1;
        }
    }
    public List<int> vals()
    {
        List<int> ok = new List<int>();
        List<House_feature> bleh = new List<House_feature>();
        bleh.AddRange(avalItems.getAvailable());
        for(int j = 0; j < bleh.Count; j++)
        {
            ok.Add(0);
        }
        if (features.Count > 0)
        {
            for (int i = 0; i < features.Count; i++)
            {
                if (!bleh.Contains(features[i]))
                {
                    bleh.Add(features[i]);
                    ok.Add(1);
                }
                else
                {
                    ok[bleh.IndexOf(features[i])]++;
                }
            }
        }
            return ok;
    }
}
