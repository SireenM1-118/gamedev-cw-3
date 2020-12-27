using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hack : MonoBehaviour
{
    int level;
    string currentscreen = "mainmenu";
    string[] level1pass = { "dollars", "millions", "money" };
    string[] level2pass = { "anonymous", "government", "systems" };

    string password;

    // Start is called before the first frame update
    void Start()
    {
        showmainmenu("welcome to hackers world !!!");
    }
    void showmainmenu(string greetings)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greetings);
        Terminal.WriteLine("press 1 to hack the bank");
        Terminal.WriteLine("press 2 to hack anonymous hackers organization");


    }

    void Onuserinput(string input)
    {
        print("This is what the user wrote " + input);

        if (input == "menu")
        {
            showmainmenu("Wolcome back!");
        }
        else if (currentscreen == "mainmenu")
        {
            setlevel(input);

        }
        else if (currentscreen == "password")
        {
            CheckPassword(input);
        }


    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("YOU WON !!");
        }
        else
        {
            Terminal.WriteLine("Try again.. or type menu to go back.");
        }
    }

    void startgame()
    {
        currentscreen = "password";
        Terminal.WriteLine("You have chosen level " + level);
        switch (level)
        {
            case 1:
                password = level1pass[Random.Range(0,level1pass.Length)];
                break;
            case 2:
                password = level2pass[Random.Range(0 , level1pass.Length)];
                break;
            default:
                break;

        }
        Terminal.WriteLine(password.Anagram());
    }



    void setlevel(string selectedlevel)
    {
        if (selectedlevel == "1")
        {
            level = 1;
            startgame();

        }

        else if (selectedlevel == "2")
        {
            level = 2;
            startgame();

        }
        else
        {
            Terminal.WriteLine("Please enter a valid number");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
