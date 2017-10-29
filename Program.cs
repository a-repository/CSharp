using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_Assign_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = 8;
            int colSize = 8;
            var board = "";

            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        board += " X ";
                    }
                    else
                    {
                        board += " # ";
                    }
                }
                board += "\n";
            }

            // Skriva ut Chess board
            Console.WriteLine(board + "\n");


            // Skriva ut en gran

            // Defineras alla variablar här
            int i, j;
            var board2 = "";
            int rows;

            // Fråga user att hur många rader ska var gran
            Console.WriteLine("var god och ange hur många rader ska vara granen?");

            // Ta in värdet från user och spara i rows
            int.TryParse(Console.ReadLine(), out rows);

            // For loop 
            for (i=1; i<=rows; i++)
            {
                //Print leading spaces
                for (j=i; j<rows; j++)
                {
                    board2 += " ";
                }

                //print stars
                for (j=1; j<=(2*i-1); j++)
                {
                    board2 += "*";
                }
                //Move to next line
                board2 += "\n";

            }

            // Print gran base 
            // Loop för att skriva ut base i mitten av botten 
            for (i=0; i<4; i++)
            {
                for (j=0; j<(rows-1); j++)
                {
                    board2 += " ";
                }
                board2 += "*\n";
            }
            
            // Skriva ut granen
            Console.WriteLine(board2);
        }
        
        
    }
}
