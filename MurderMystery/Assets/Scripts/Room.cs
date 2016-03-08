using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room : MonoBehaviour {
    private List<Interaction> available;
    private List<Room> connections;
	// Use this for initialization
	void Start () {
        available = new List<Interaction>();
        connections = new List<Room>();
	}

    // Update is called once per frame
    void Update()
    {
    }
    public void addRoom(Room m)
    {
        connections.Add(m);
    }
}
