using Microsoft.SemanticKernel;
using SKLIb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFunctionCalling
{
    public class NotificationService : IFunctionCalled
    {
        public event EventHandler<FunctionCallEventArgs>? FunctionCalled;

        [KernelFunction]
        public void SendEmail(string to, string subject, string body)
        {
            FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(SendEmail)));
            var logMsg = $"Sending email to {to} with subject '{subject}' and body {body}.";
            Console.WriteLine(logMsg);
            FunctionCalled?.Invoke(this, new FunctionCallEventArgs(logMsg));

            // Simulate email sending
        }
    }
}
