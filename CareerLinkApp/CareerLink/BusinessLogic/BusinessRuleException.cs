using System;

namespace CareerLink.BusinessLogic
{
    
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message)
        {
        }
    }
}
