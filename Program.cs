using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSC_SudokuVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            SudokuBoard sudo = new SudokuBoard(args[0]);
            SudokuVerifier verifier = new SudokuVerifier();
            if(!sudo.BoardIsValid)
            {
                Console.WriteLine("Sudoku schema not valid for 9x9");
            }
            else
            {
                if (verifier.Verify(sudo.board))
                {
                    Console.WriteLine("Sudoku schema is valid.");
                }
                else
                {
                    Console.WriteLine("Sudoku schema is not valid.");
                }
            }
            Console.ReadLine();
            
        }
    }
}
