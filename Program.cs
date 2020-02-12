using System;

namespace CSharp_Exercise_4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInput();
            // input += GetInput();
            input = AddSmileyToEnd( input );
            input = AddSmileyToBeginning( input );
            WriteName( input );
        }

        static string GetInput()
        {
            Console.WriteLine( "Please input some text:" );
            return Console.ReadLine();
        }

        static string AddSmileyToEnd( string input )
        {
            input = input+":)";
            return input;
        }

        static string AddSmileyToBeginning( string input )
        {
            input = ":("+input;
            return input;
        }

        static void WriteName( string input ) {
            Console.WriteLine( input );
        }
    }
}
