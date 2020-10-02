namespace NeuralNetworkLesson.Sudoku
{
    public class Col : ValuesEntity
    {
        public override string ToString()
        {
            return string.Join(",", Values);
        }
    }
}
