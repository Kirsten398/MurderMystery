using UnityEngine;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Parser : MonoBehaviour {
    List<House_feature> shop = new List<House_feature>();
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    public List<House_feature> getShop(string fileName)
    {
        // Handle any problems that might arise when reading the text
        try
        {
            string line;
            // Create a new StreamReader, tell it which file to read and what encoding the file
            // was saved as
            StreamReader theReader = new StreamReader(fileName, Encoding.Default);
            // Immediately clean up the reader after this block of code is done.
            // You generally use the "using" statement for potentially memory-intensive objects
            // instead of relying on garbage collection.
            // (Do not confuse this with the using directive for namespace at the 
            // beginning of a class!)
            using (theReader)
            {
                line = theReader.ReadLine();
                if (line != null)
                {
                    // While there's lines left in the text file, do this:
                    do
                    {
                        // Do whatever you need to do with the text line, it's a string now
                        // In this example, I split it into arguments based on comma
                        // deliniators, then send that array to DoStuff()
                        string[] entries = line.Split('|');
                        House_feature op = new House_feature();
                        op.Create(entries[0], System.Int32.Parse(entries[1]), System.Single.Parse(entries[2]), System.Single.Parse(entries[3]), System.Single.Parse(entries[4]), System.Int32.Parse(entries[5]));
                        if (entries.Length > 0)
                        line = theReader.ReadLine();
                    }
                    while (line != null);
                }
                // Done reading, close the reader and return true to broadcast success    
                theReader.Close();
                return shop;
            }
        }
        catch (System.Exception e)
        {
            return null;
        }
    }
}
