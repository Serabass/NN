using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkLesson.Sudoku
{
    public class Cell : ValuesEntity
    {
        public bool Solved => !Values.Contains(0) && Values.Distinct().Count() == Values.Count();

        public override string ToString()
        {
            return string.Join(",", Values);
        }
    }
}
