namespace Casting_Implicit_Explicit_Operator_Exception.Exceptions
{
    public class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException() { }

        public ProductCountIsZeroException(string message) : base(message) 
        { 

        }
    }
}
