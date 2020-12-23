using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        MainMenu("welcome to this hacking game!!");
    }

    void MainMenu(string greeting)
    {
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("press 1 to hack the bank");
        Terminal.WriteLine("press 2 to hack bus station");
        Terminal.WriteLine("press 3 to hack the airport");


    }
}
