using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSC_SudokuVerifier
{
    class SudokuVerifier: ISudokuVerifier
    {
        private int[,] grid = new int[9, 9];
        public bool Verify(List<string> schema)
        {
            FillGrid(schema);
            return Validate();
        }
        private void FillGrid(List<string> schema)
        {
            int r = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    grid[j, i] = int.Parse(schema[i+r]);
                }
                r = r + 9;
            }
        }
        private bool Validate()
        {
            //validate rows
            for (int j = 0; j < 9; j++)
            {
                var used = new bool[10];
                for (int i = 0; i < 9; i++)
                {
                    var number = grid[j, i];
                    if(number == 0 || used[number] == true)
                    {
                        return false;
                    }
                    used[number] = true;
                }
            }
            //validate columns
            for (int c = 0; c < 9; c++)
            {
                var used = new bool[10];
                for (int r = 0; r < 9; r++)
                {
                    var number = grid[r, c];
                    if (number == 0 || used[number] == true)
                    {
                        return false;
                    }
                    used[number] = true;
                }
            }
            return true;
        }
    }
}
