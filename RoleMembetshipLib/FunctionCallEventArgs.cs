namespace SKFunctionCalling
{
    public class FunctionCallEventArgs : EventArgs
    {
        public FunctionCallEventArgs(string functionName)
        {
            FunctionName = functionName;
        }

        public string FunctionName { get; private set; }
    }
}