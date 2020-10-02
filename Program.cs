using System;
using System.Collections.Generic;
using NeuralNetworkLesson.Sudoku;

namespace NeuralNetworkLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            SudokuField field = new SudokuField(Difficulty.Easy);
            Console.WriteLine(field.Solved);
            Console.WriteLine(field.ToString());
        }
    }
}
