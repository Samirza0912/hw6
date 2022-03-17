using System;
using task1.Models;

namespace task1
{
    /*Product class :
- No
 - Name
- Price
- Count

Book class - Productdan miras alır 
 - Genre 
 
No, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz
Genre dəyəri təyin olunmadan Book yaradıla bilməz

Proqram run olduqda bizden say istemelidi, sayi daxil etdikden sonra hemin uzunluqda bir book arrayi yaradilmalidir
daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelidi, dovrun her stepinde yeni bir book obyekti yaranib array-e elave edilmelidir (Bura qeder dersde etdiklerimize uygundur)


Arrayi tam olaraq doldurduqdan sonra menu penceresi gorunmelidir console-da ve orada asagidaki kimi yazilmalidir:
1. Kitablari qiymete gore filterle
2. Butun kitablari goster
0. Proqrami bagla



bu gorsendeikden sonra proqram bizden bir input daxil etmeyimizi istemelidi

Eger daxil etdiyimiz deyer 1 olarsa proqram kitablari filter edib bize gostermek ucun bizden minPrice ve maxPrice deyerlerini daxil etmeyimizi istemelidi. Biz her iki deyeri daxil etdikden sonra proqram yaranmis kitab arrayindeki kitablari gonderdiyimiz min ve max price deyerlerine gore filter edib bize gostermelidi. Daha sonra yeniden menu penceresi gorunmelidir.

Eger daxil etdiyimiz deyer 2 olarsa butun kitablar gosterilmelidir ve sonra menu penceresi gorsenmelidir yene

Eger daxil etdiyimiz deyer 0 olarsa proqram baglanmalidir

Eger daxil etdiyimiz deyer bu 3-unden basqa bir sey olarsa proqram bizden yeniden secim etmeyimizi istemelidir ta ki duz secim edenedek

     */
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("please enter the count: ");
            int type_count = int.Parse(Console.ReadLine());

            Book[] books = new Book[type_count];
            for (int i = 0; i < type_count; i++)
            {
                Console.WriteLine("Please enter the Genre:  ");
                string Genre = Console.ReadLine();

                Console.WriteLine("Please enter the No:  ");
                int No = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the Name:  ");
                string Name = Console.ReadLine();

                Console.WriteLine("Please enter the Price:  ");
                double Price = double.Parse(Console.ReadLine());

                books[i] = new Book(Genre, No, Name, Price);



            }
            Console.WriteLine("-------------");

            do
            {
                int p = Check("Menu Bar\n1-filter the books according to the prices\n2-show all book\n0-end program");
                if (p == 2)
                {
                    foreach (var item in books)
                    {
                        item.InfoBook();

                        Console.WriteLine("++++++++++++++++++++++");
                    }
                }
                else if (p == 1)
                {
                    Console.Write("Enter min price= ");
                    double MinimumPrice = double.Parse(Console.ReadLine());
                    Console.Write("Enter max price= ");
                    double MaximumPrice = double.Parse(Console.ReadLine());
                    for (int i = 0; i < type_count; i++)
                    {
                        if (MinimumPrice <= books[i].Price && MaximumPrice>=books[i].Price)
                        {
                            books[i].InfoBook();
                        }
                    }
                }
                else if (p == 0)
                {
                    return;
                }

            } while (true);


            static int Check(string name)
            {
                int n;

                do
                {
                    Console.Write(name);
                    n = int.Parse(Console.ReadLine());

                } while (n > 2 || n < 0);
                return n;
            }




        }   }
}
