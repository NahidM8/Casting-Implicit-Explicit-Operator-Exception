namespace Casting_Implicit_Explicit_Operator_Exception.Exceptions
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException() { }

        public CapacityLimitException(string message) : base(message) 
        { 

        }
    }
}
