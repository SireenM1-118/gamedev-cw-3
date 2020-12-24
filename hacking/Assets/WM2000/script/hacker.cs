using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class اش : MonoBehaviour
{

    int level;
    string currentscreen = "mainmenu";

    // Start is called before the first frame update
    void Start()
    {

        showmainmenu("welcome to hackers world !!!");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showmainmenu(string greetings)
    {

        Terminal.WriteLine(greetings);
        Terminal.WriteLine("press 1 to hack the bank");
        Terminal.WriteLine("press 2 to hack anonymous hackers organisation" );


    }

    void onuserinput (string input)
    {
        if(currentscreen == "mainmenu")
        {
            setlevel(input);

        }
        else if(currentscreen == "password")
        {


        }

        void setlevel(string selectedlevel)
        {
            if(selectedlevel == "1")
            {
                level = 1;
                print(level);
               randompass();
            }

            else if(selectedlevel == "2")
            {
                level = 2;
                print(level);
                randompass();
            }
            else
            {
                Terminal.WriteLine("wrong input. please enter a valid input.");
            }


        }

        void startgame()
        {
            Terminal.WriteLine("You have chosen level " + level);
            currentscreen = "password";
        }

        void randompass()
        {
            startgame();
            switch (level)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;

            }

        }










    }







}
