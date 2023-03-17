namespace SirvIces.services.math
{
    public class FunctionResult
    {
        private readonly IFunction _function;
        public FunctionResult(IFunction function)
        {
            _function = function;
        }
        public int GetResult(int x)
        {
            return _function.Calculate(x);
        }
    }
}
