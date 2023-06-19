using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;


string[] products = File.ReadAllLines("store.txt", Encoding.UTF8);
while (true)
{
    Console.WriteLine(@"Выберите действие:
a) Показать список продуктов
b) Добавить новый продукт
с) Продать продукт");
    string UserInput = Console.ReadLine();

    if (UserInput == "a")
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);

        }
    }
    else if (UserInput == "b")
    {
        Console.Write("Вводите имя: ");
        string newProductname = Console.ReadLine();
        Console.Write("Вводите количество: ");
        int NewProductQuantity = int.Parse(Console.ReadLine());
        bool flag = true;
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].StartsWith(newProductname))
            {
                var temp = products[i].Split()[1];
                products[i] = newProductname + " " + (int.Parse(temp) + NewProductQuantity);
                flag = false;
                break;
            }
        }

        if (flag)
        {
            string[] newProds = new string[products.Length + 1];
            for (int i = 0; i < products.Length; i++)
            {
                newProds[i] = products[i];
            }
            newProds[newProds.Length - 1] = newProductname + " " + NewProductQuantity;
            products = newProds;
        }
        File.WriteAllLines("store.txt", products);

    }
    else if (UserInput == "c")
    {
        Console.Write("Вводите имя для продажи: ");
        string Productname = Console.ReadLine();
        Console.Write("Вводите количество: ");
        int ProductQuantity = int.Parse(Console.ReadLine());
        bool productExists = false;
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].StartsWith(Productname))
            {
                productExists = true;
                var temp = products[i].Split()[1];
                var check = int.Parse(temp) - ProductQuantity;
                if (check < 0)
                {
                    Console.WriteLine("Недостаточно товаров в списке");
                }
                else
                {
                    products[i] = Productname + " " + check;
                }
            }
        }
        if (!productExists)
        {
            Console.WriteLine("\nПродукт не существует");
            //hello
            //hello
            //hello
            //hello
        }
    }
}
