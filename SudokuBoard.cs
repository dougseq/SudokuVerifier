using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSC_SudokuVerifier
{
    public class SudokuBoard
    {
        public int rows = 9;
        public int columns = 9;
        public bool BoardIsValid = false;
        public List<string> board = new List<string>();
        

        public SudokuBoard(string stringvalues)
        {
            if (IsValid(stringvalues))
            {
                CreateBoard(stringvalues);
            }
        }
        private bool IsValid(string values)
        {
            string[] arr = values.Split(',');
            return arr.Length == 81 ? true : false;
        }
        private void CreateBoard(string values)
        {
            BoardIsValid = true;
            string[] arrValues = values.Split(',');
            for (int i = 0; i < arrValues.Length; i++)
            {
                board.Add(arrValues[i]);
            }
        }
    }
}
