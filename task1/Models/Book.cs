using System;
namespace task1.Models
{
    public class Book:Product
    {
        public string Genre;

        public Book(string genre, int no, string name, double price):base(no,name,price)
        {
            this.Genre = genre;
            this.No = no;
            this.Name = name;
            this.Price = price;
        }
        public void InfoBook()
        {
            Console.Write($"Genre: {Genre}\nNo: {No}\nName: {Name}\nPrice: {Price}\n");
        }
    }
}
