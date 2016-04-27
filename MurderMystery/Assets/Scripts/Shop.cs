using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop : MonoBehaviour {
    List<House_feature> availableItems;
    House_feature[] aval;
    Parser p = new Parser();
	// Use this for initialization
	void Start () {
        availableItems = p.getShop("Feature_List.muda");
        aval = availableItems.ToArray();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void purchaseItem(Business ok,int ID)
    {
        if (ok.Money1 > aval[ID].purchase())
        {
            ok.makePurchase(aval[ID]);
        }
    }
    /*
        IDList
        0.Zombie
        1.Jack In the box
        2.Minor ghost
        3.Witch
        4.Vamp
        5.Werewolf
        6.Minor Black Cat
        7.Minor Spider
        8.Cobwebs
        9.THIS
    */
}
