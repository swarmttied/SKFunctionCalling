using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFunctionCalling
{
    public class NotificationService
    {
        [KernelFunction]
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine("Function: SendEmail");
            Console.WriteLine($"Sending email to {to} with subject '{subject}' and body {body}.");
            // Simulate email sending
        }
    }
}
