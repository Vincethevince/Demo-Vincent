using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTextDatei : MonoBehaviour {

    public Transform obj;

    void Start()
    {
        int counter = 0;
        string line;

        // Read the file and display it line by line.  
        System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\Legion\Documents\test.txt");
        while ((line = file.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
            counter++;
        }

        file.Close();
        //System.Console.WriteLine("There were {0} lines.", counter);
        // Suspend the screen.  
        //System.Console.ReadLine();

        for (int i = 0; i < counter; i++)
        {
            Instantiate(obj, new Vector3(i, (float)0.5 , i), Quaternion.identity);
        }
    }
}
