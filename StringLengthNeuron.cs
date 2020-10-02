using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkLesson
{
    public class StringLengthNeuron : NeuronAbstract<string, int>
    {
        public override int ProcessInputData(string input)
        {
            return input.Length;
        }

        public override string RestoreInputData(int output)
        {
            var a = new List<char>(output);
            return string.Join("", a.Select(a => '0'));
        }

        public override void Train(string input, int expectedResult)
        {
            var actualResult = input.Length;
            LastError = expectedResult - actualResult;
            var correction = (LastError / actualResult) * Smoothing;
            weight += correction;
        }
    }
}