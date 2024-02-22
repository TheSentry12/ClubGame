using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the OMNINIpotent club! \n");
        Console.WriteLine("where only the most powerful people can be found! \n");

        string[] guests = new string[]
        {"The Beyonder","Galactus","Eternity","Oblivion","Legion" ,
      "Hela","The Darkest Knight ","The X-Men","Dr Manhattan" ,"yo mama ugly"};

        string[] clubmembers = new string[10];

        int guestindex = 0;

        foreach (var guest in guests)
        {

            Console.WriteLine($"Do you want to let {guest} in the club? (Y/N)");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {

                clubmembers[guestindex] = guest;
                guestindex++;

                Console.WriteLine($"You have invited {guest} to the club");
            }




        }


        foreach (var member in clubmembers)
        {
            Console.WriteLine(member);
        }


        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();

    }

}
