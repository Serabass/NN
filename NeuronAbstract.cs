namespace NeuralNetworkLesson
{
    public abstract class NeuronAbstract<I, O>
    {
        protected decimal weight = 0.5m;

        public O LastError { get; protected set; }

        public decimal Smoothing = 0.00001m;

        public abstract O ProcessInputData(I input);

        public abstract I RestoreInputData(O output);

        public abstract void Train(I input, O expectedResult);
    }
}