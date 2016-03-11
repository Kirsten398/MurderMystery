using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class House : MonoBehaviour {
    List<House_feature> features;
    int maxAssets = 10;
    int totalAssets;
    void Start()
    {
    }
    void Update()
    {

    }
    void AddAsset(House_feature m)
    {
        if (totalAssets + m.AssetPoints1 <= maxAssets)
        {
            features.Add(m);
            totalAssets += m.AssetPoints1;
        }
    }
}
