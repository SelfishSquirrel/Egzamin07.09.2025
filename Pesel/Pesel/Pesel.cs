using System;
using System.Collections.Generic;

class MainProgram()
{
    static char DefineUser(char[] pesel)
    {
        if(pesel[pesel.Length - 2] % 2 == 0)
        {
            return 'K';
        }

        return 'M';
    }

    static bool GetLogicalValue(char[] pesel)
    {
        int[] WagaCyfr = new int[10] {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
        int S = 0;
        int M = 0;
        int R = 0;

        for (int i = 0; i < pesel.Length - 1; i++)
        {
           S += int.Parse(pesel[i].ToString()) * WagaCyfr[i];
        }

        M = S % 10;

        if(M == 0)
        {
            R = 0;
        }
        else
        {
            R = 10 - M;
        }

        Console.WriteLine(R);

        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj numer pesel:");
        string input = Console.ReadLine();

        char[] pesel = input.ToCharArray();

        //07232410090

        //07211613614

        Console.WriteLine(DefineUser(pesel));

        bool PeselLogicalValue = GetLogicalValue(pesel);
        
        if( PeselLogicalValue )
        {
            Console.WriteLine("Zgodne");
        }
        else
        {
             Console.WriteLine("Niezgodne");
        }
    }
}