using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SemanticKernel;
using SKLIb;

namespace InquiryLib
{
    public class AgreementService : IFunctionCalled
    {
        public event EventHandler<FunctionCallEventArgs> FunctionCalled;

        [KernelFunction]
        public Agreement GetAgreementByEnrollmentId(string enrollmentId)
        {
            return new Agreement
            {
                EnrollmentId = enrollmentId,
                ClientName = "Sample Client",
                SignedDate = DateTime.UtcNow.AddMonths(-6),
                ExpirationDate = DateTime.UtcNow.AddMonths(6),
                Status = "Active"
            };
        }

        [KernelFunction]
        public Agreement[] GetAgreementsByClientName(string clientName)
        {
            return new Agreement[]
            {
                new Agreement
                {
                    EnrollmentId = "ENR001",
                    ClientName = clientName,
                    SignedDate = DateTime.UtcNow.AddMonths(-12),
                    ExpirationDate = DateTime.UtcNow.AddMonths(12),
                    Status = "Active"
                },
                new Agreement
                {
                    EnrollmentId = "ENR002",
                    ClientName = clientName,
                    SignedDate = DateTime.UtcNow.AddMonths(-18),
                    ExpirationDate = DateTime.UtcNow.AddMonths(6),
                    Status = "Expired"
                }
            };
        }
    }
}
