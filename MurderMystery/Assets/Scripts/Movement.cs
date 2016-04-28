using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    Animator anim;
    public Customer cust;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float s = cust.getSanity();

        anim.SetFloat("Sanity", s);
    }
}
