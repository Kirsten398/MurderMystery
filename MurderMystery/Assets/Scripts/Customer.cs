using UnityEngine;
using System.Collections;

public class Customer : MonoBehaviour {
    string nahme;
    bool male;
    bool adult;
    float patience; //value between 1 and 10 on how patient a customer is
    float sanity; //value between 1 and 10 on how sane a customer is
    float stamina; //value between 1 and 10 on how long a person can stay without passing out
    float reason; //value between 0 and 1 on how likely the person is to be affected by the scares
	void Start () {
        nahme = "Suzy";
        male = false;
        adult = false;
        patience = 1.2f;
        sanity = 7.1f;
        stamina = 5.5f;
        reason = 0.1f;
	}
	
    public void createCustomer(string n, bool m, bool a, float p, float san, float st, float r)
    {
        nahme = n;
        male = m;
        adult = a;
        patience = p;
        sanity = san;
        stamina = st;
        reason = r;
    }

	// Update is called once per frame
	void Update () {
	
	}

    public float getSanity()
    {
        return sanity;
    }
}
