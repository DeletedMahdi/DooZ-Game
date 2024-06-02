

using System.Media;

static void Main()
{
    
   

            SoundPlayer whatislove = new SoundPlayer("Baby-dont-hurt-me-slowed-meme-sound1.wav");
            whatislove.Load();

            whatislove.PlayLooping();




    char[] jadval = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    string namep1;
    string namep2;
    int round = 1;
    int scorep1 = 0;
    int scorep2 = 0;
    void getname()
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.Write("enter player 1 name: ");
        namep1 = Console.ReadLine();
        Console.Clear();
        Console.Write("enter player 2 name: ");
        namep2 = Console.ReadLine();
    }






    char charkheshround()
    {
        if (round % 2 == 0)
        {
            return 'X';
        }
        else
        {
            return 'O';
        }
    }
    string pround()
    {

        if (charkheshround() == 'X')
        {
            return namep1;

        }
        else
        {
            return namep2;
        }

    }
    void setscore()
    {

        if (charkheshround() == 'X')
        {
            scorep1++;

        }
        else
        {
            scorep2++;
        }

    }
    void printtable()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("\n\n\n");
        Console.WriteLine($"                player1: {namep1}      score: {scorep1}                 player2: {namep2}     score:{scorep2}");
        Console.WriteLine("                  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("                  $                                       $");
        Console.WriteLine("                  $                                       $");
        Console.WriteLine($"                  $            {jadval[0]}  | {jadval[1]}  | {jadval[2]}                $");
        Console.WriteLine("                  $           ----|----|----              $");
        Console.WriteLine($"                  $            {jadval[3]}  | {jadval[4]}  | {jadval[5]}                $");
        Console.WriteLine("                  $           ----|----|----              $");
        Console.WriteLine($"                  $            {jadval[6]}  | {jadval[7]}  | {jadval[8]}                $");
        Console.WriteLine("                  $           ----|----|----              $");
        Console.WriteLine("                  $                                       $");
        Console.WriteLine("                  $                                       $");
        Console.WriteLine("                  $                                       $");
        Console.WriteLine("                  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

    }
    bool jadvalfull(char input)
    {
        int x = (int)input - 49;
        if (jadval[x] == 88 || jadval[x] == 79)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void errorprint()
    {
        Console.WriteLine("Invalid Number , Next Player");
    }

    void getinput()
    {

        try
        {

            round++;
            Console.WriteLine("                 enter number 1-9: "); Console.Write("                 player("); Console.Write(pround()); Console.Write(") ---> "); Console.Write(charkheshround()); Console.Write(":");
            char input = Convert.ToChar(Console.ReadLine());
            while (jadvalfull(input))
            {

                Console.WriteLine("                 warning!!! table is full , next player ... ");
                round++;

                Console.Write("                 player("); Console.Write(pround()); Console.Write(") ---> "); Console.Write(charkheshround()); Console.Write(":");
                input = Convert.ToChar(Console.ReadLine());
            }
            if (input == '1')
            {
                jadval[0] = charkheshround();
            }
            else if (input == '2')
            {
                jadval[1] = charkheshround();
            }
            else if (input == '3')
            {
                jadval[2] = charkheshround();
            }
            else if (input == '4')
            {
                jadval[3] = charkheshround();
            }
            else if (input == '5')
            {
                jadval[4] = charkheshround();
            }
            else if (input == '6')
            {
                jadval[5] = charkheshround();
            }
            else if (input == '7')
            {
                jadval[6] = charkheshround();
            }
            else if (input == '8')
            {
                jadval[7] = charkheshround();
            }
            else if (input == '9')
            {
                jadval[8] = charkheshround();
            }
            
        }

        catch (Exception ex)
        {
            
           
            
        }

    }
    getname();
    bool isfull()
    {
        for (int i = 0; i < 9; i++)
        {
            if (jadval[i] != 'X' && jadval[i] != 'O')
            {
                return false;
            }

        }
        return true;



    }

    bool iswin()
    {
        if (jadval[0] == jadval[1] && jadval[1] == jadval[2])
        {
            return true;
        }
        else if (jadval[3] == jadval[4] && jadval[4] == jadval[5])
        {
            return true;
        }
        else if (jadval[6] == jadval[7] && jadval[7] == jadval[8])
        {
            return true;
        }
        else if (jadval[0] == jadval[3] && jadval[3] == jadval[6])
        {
            return true;
        }
        else if (jadval[1] == jadval[4] && jadval[4] == jadval[7])
        {
            return true;
        }
        else if (jadval[2] == jadval[5] && jadval[5] == jadval[8])
        {
            return true;
        }
        else if (jadval[0] == jadval[4] && jadval[4] == jadval[8])
        {
            return true;
        }
        else if (jadval[2] == jadval[4] && jadval[4] == jadval[6])
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    bool notend()
    {
        if (iswin() || isfull())
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    string winner()
    {
        if (isfull())
        {


            scorep1++;
            scorep2++;
            return "                 Congratulations , " + namep1 + " And " + namep2 + " Winner!! (Titap Talayi Basteye 2 Tayi :D)";

        }
        else
        {
            setscore();
            return "                 Congratulations , " + pround() + " is Winner!!(Titap Talayi :D)";
        }

    }
    ConsoleKeyInfo key;

    do
    {



        while (notend())
        {

            printtable();
            getinput();

            Console.Clear();
            printtable();
        }

        Console.WriteLine(winner());
        if (OperatingSystem.IsWindows())
        {
            if (notend() == false)
            {
                
                SoundPlayer boosBedeh = new SoundPlayer("Boosbedeh.wav");
                boosBedeh.Load();
                boosBedeh.Play();
                
            }


        }
        for (int i = 0; i < 9; i++)
        {
            jadval[i] = Convert.ToChar(i + 1 + "");
        }
        Console.WriteLine("                 Press ESC Key To Exit...");
        Console.WriteLine("                 Press Any Key To Continue...");
        key = Console.ReadKey();
        whatislove.Load();
        whatislove.Play();
    }
    while (key.Key != ConsoleKey.Escape);


}

Main();