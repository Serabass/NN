using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkLesson.Sudoku
{
    public abstract class ValuesEntity
    {
        public List<byte> Values = new List<byte>();

        public bool Solved => !Values.Contains(0) && Values.Distinct().Count() == Values.Count();

        public abstract override string ToString();
    }
}
