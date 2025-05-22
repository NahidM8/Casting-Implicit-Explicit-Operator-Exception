using Casting_Implicit_Explicit_Operator_Exception.Exceptions;

namespace Casting_Implicit_Explicit_Operator_Exception.Models
{
    public class Book:Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public override void Sell()
        {
            if (Count == 0)
                throw new ProductCountIsZeroException($"{Name} is out of stock.");

            Count--;
            TotalIncome += Price;
            Console.WriteLine($"{Name} is sold");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Book ID: {Id}\nName: {Name}\nAuthor: {AuthorName}\nPageCount: {PageCount}\nPrice: {Price}\nCount: {Count}\nTotalIncome: {TotalIncome}");
        }
        public Book(string name, double price, string authorName, int pageCount,int count = 1)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
            Count = count;

            TotalIncome = 0;
        }
    }
}
