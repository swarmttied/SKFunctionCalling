using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFunctionCalling
{
    public interface IFunctionCalled
    {
        event EventHandler<FunctionCallEventArgs> FunctionCalled;
    }
}
