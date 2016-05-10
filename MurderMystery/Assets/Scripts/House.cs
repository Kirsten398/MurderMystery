using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class House : MonoBehaviour {
    List<House_feature> features;
    int maxAssets = 10;
    int totalAssets;
    List<Transform> Line;
    void Start()
    {
        Line = new List<Transform>();
    }
    void Update()
    {
      
    }

    public void AddAsset(House_feature m)
    {
        if (totalAssets + m.AssetPoints1 <= maxAssets)
        {
            features.Add(m);
            totalAssets += m.AssetPoints1;
        }
    }
    public int[] vals()
    {
        List<int> ok = new List<int>();
        List<House_feature> bleh = new List<House_feature>();
        for(int i = 0; i < features.Count; i++)
        {
            if (!bleh.Contains(features[i])){
                bleh.Add(features[i]);
                ok.Add(1);
            }
            else
            {
                ok[bleh.IndexOf(features[i])]++;
            }
        }
        return ok.ToArray();
    }
}
