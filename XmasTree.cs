using System;
// Printing out an Xmas Tree 
// Author: Reza Rezaee


namespace Xmas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriva ut en gran

            // Defineras alla variablar här
            int i, j;
            var board2 = "";
            int rows;

            // Ask user to enter the number of rows for Xmas Tree
            Console.WriteLine("Please enter a number of row to define the length of Xmas Tree!");

            // Take in the number and save it in variable "rows"
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
            // Loop throught and print the base for the tree
            for (i=0; i<4; i++)
            {
                for (j=0; j<(rows-1); j++)
                {
                    board2 += " ";
                }
                board2 += "*\n";
            }
            
            // Print the whole board/Xmas tree
            Console.WriteLine(board2);
        }
    }
}
