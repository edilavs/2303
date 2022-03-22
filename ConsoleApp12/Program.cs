using System;

namespace ConsoleApp12
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook
            {
                Name = "Pavilion",
                BrandName="HP",
                Price=1900
            };
            Notebook notebook2 = new Notebook
            {
                Name = "L3",
                BrandName = "Lenovo",
                Price = 1800
            };
            Notebook notebook3 = new Notebook
            {
                Name = "Elite Dragonfly",
                BrandName = "HP",
                Price = 3939
            };



            Notebook[] Notebooks = new Notebook[] {notebook1,notebook2,notebook3 };
            Console.WriteLine("minprice daxil edin:");
            double minPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("maxprice daxil edin:");
            double maxPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(NewNotebookArr(Notebooks,minPrice,maxPrice));
            Console.WriteLine("yeni siyahi:");
           
           
        }

        static void NewNotebookArr(Notebook[] notebooks, double minPrice, double maxPrice)
        {
            for(int i = 0; i < notebooks.Length; i++)
            {
                if(notebooks[i].Price>=minPrice && notebooks[i].Price<=maxPrice )
                {
                    Console.WriteLine("Bu Notebook'un qiymeti uygundur.");
                    int counter = 0;
                    counter++;
                    string[]  newArr = new string[] ;
                    Console.WriteLine(newArr[i]);
                }
                
            }
        }


    }
}
