namespace School_Management_System.Middleware.ExceptionHandling
{
    public abstract class ExceptionHandlingDomain : Exception
    {
        public ExceptionHandlingDomain(string message) : base(message)
        {

        }
    }
    public  class DomainNotFoundException : ExceptionHandlingDomain
    {
        public DomainNotFoundException(string message) : base(message)
        {
        }
    }
    public class DomainServiceException : ExceptionHandlingDomain
    {
        public DomainServiceException(string message) : base(message)
        {
        }
    }
}
