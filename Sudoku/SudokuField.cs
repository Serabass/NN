using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NeuralNetworkLesson.Sudoku
{
    public class SudokuField
    {
        public SudokuField(Difficulty difficulty, int index = 0)
        {
            var path = Path.Combine("sudoku-maps", $"{difficulty}.map");
            var p = File.ReadAllLines(path);
            var rows = p[index].SplitInParts(9);
            foreach (var row in rows)
            {
                Rows.Add(new Row(this, row));
            }
        }

        public List<Row> Rows = new List<Row>();

        public List<Col> Cols
        {
            get
            {
                var result = new List<Col>();
                for (var i = 0; i < 9; i++)
                {
                    result.Add(Col(i));
                }

                return result;
            }
        }

        public List<Cell> Cells
        {
            get
            {
                var result = new List<Cell>();
                for (var r = 0; r < 9; r++)
                {
                    for (var c = 0; c < 9; c++)
                    {
                        result.Add(Cell(r, c));
                    }
                }

                return result;
            }
        }

        public Cell Cell(int row, int col)
        {
            var Values = new List<byte>();
            for (var r = 3 * row; r < 3 * row + 3; r++)
            {
                for (var c = 3 * col; c < 3 * col + 3; c++)
                {
                    Values.Add(Rows[r].Values[c]);
                }
            }

            return new Cell()
            {
                Values = Values
            };
        }

        public Col Col(int col)
        {
            return new Col()
            {
                Values = Rows.Select(row => row.Values[col]).ToList()
            };
        }

        public bool Solved
        {
            get { return Cols.All(col => col.Solved)
                         && Rows.All(row => row.Solved)
                         && Cells.All(cell => cell.Solved); }
        }

        public override string ToString()
        {
            var result = "┌───────┬───────┬───────┐\n";
            var index = 0;
            foreach (var row in Rows)
            {
                result += row;

                if (index != 8)
                {
                    if ((index + 1) % 3 == 0)
                    {
                        result += "\n├───────┼───────┼───────┤";
                    }
                }
                else
                {
                    result += "\n└───────┴───────┴───────┘";
                }

                result += "\n";
                index++;
            }

            return result;
        }
    }
}