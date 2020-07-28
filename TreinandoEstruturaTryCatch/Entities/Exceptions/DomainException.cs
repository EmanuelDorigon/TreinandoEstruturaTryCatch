using System;

namespace TreinandoEstruturaTryCatch.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        { 
        }
    }
}
