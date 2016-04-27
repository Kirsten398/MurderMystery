using UnityEngine;
using System.Collections;

public class House_feature : MonoBehaviour {
    string nahme;
    int cost; //Available budget in fictional currency
    float scary; //value between 0 and 20 on how scary the prop
    float happiness; //value between 0 and 5 on how happy your customers get from seeing this
    float originality; //value between 0 and 1 on how original the prop is
    int AssetPoints;

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
        nahme = "Zombie";
        cost = 100;
        scary = 0.12f;
        happiness = 0.22f;
        originality = 0.1f;
        AssetPoints1 = 2;
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
  public int purchase(){
        return cost;
  }
}
