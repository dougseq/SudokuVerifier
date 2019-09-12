using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSC_SudokuVerifier
{
    interface ISudokuVerifier
    {
        bool Verify(List<string> sudokuSchema);
    }
}
