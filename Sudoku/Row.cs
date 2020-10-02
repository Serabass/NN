using System.Collections.Generic;

namespace NeuralNetworkLesson.Sudoku
{
    public class Row : ValuesEntity
    {
        public SudokuField field;

        public Row(SudokuField field, string input)
        {
            this.field = field;
            foreach (var c in input)
            {
                Values.Add(byte.Parse(c.ToString()));
            }
        }

        public override string ToString()
        {
            var result = "|";
            int index = 0;

            foreach (var col in Values)
            {
                if (col == 0)
                {
                    result += "  ";
                }
                else
                {
                    result += $" {col}";
                }

                if ((index + 1) % 3 == 0)
                {
                    result += " │";
                }

                index++;
            }

            return result;
        }
    }
}