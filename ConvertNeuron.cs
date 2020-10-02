
namespace NeuralNetworkLesson
{
    class ConvertNeuron : NeuronAbstract<decimal, decimal>
    {
        public override decimal ProcessInputData(decimal input)
        {
            return input * weight;
        }

        public override decimal RestoreInputData(decimal output)
        {
            return output / weight;
        }

        public override void Train(decimal input, decimal expectedResult)
        {
            var actualResult = input * weight;
            LastError = expectedResult - actualResult;
            var correction = (LastError / actualResult) * Smoothing;
            weight += correction;
        }
    }
}
