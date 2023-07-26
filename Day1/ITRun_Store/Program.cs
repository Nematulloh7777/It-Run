


using System.Collections.Generic;
using System.Text;



string[] products = File.ReadAllLines("store.txt", Encoding.UTF8);
while (true)
{
    Console.WriteLine("Hello!");
    Console.WriteLine(@"Выберите действие:
a) Показать список продуктов
b) Добавить новый продукт
с) Продать продукт");

    string userInput = Console.ReadLine();
    if (userInput == "a")
    {
        Console.Clear();
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
    else if (userInput == "b")
    {
        Console.Clear();

        Console.Write("Вводите имя продукта: ");
        string newProductName = Console.ReadLine();
        Console.Write("Вводите количество продукта: ");
        int newProductQuantity = int.Parse(Console.ReadLine());
        bool flag = true;
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].StartsWith(newProductName))
            {
                var temp = products[i].Split()[1];
                products[i] = newProductName + " " + (int.Parse(temp) + newProductQuantity);
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
            newProds[newProds.Length - 1] = newProductName + " " + newProductQuantity;
            products = newProds;
        }
        File.WriteAllLines("store.txt", products);
    }
    else if (userInput == "c")
    {
        Console.Clear();

        Console.Write("Вводите имя продукта для продажи: ");
        string productName = Console.ReadLine();
        Console.Write("Вводите количество: ");
        int productQuantity = int.Parse(Console.ReadLine());
        bool productExists = false;
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].StartsWith(productName))
            {
                productExists = true;
                var temp = products[i].Split()[1];
                var check = int.Parse(temp) - productQuantity;
                if (check < 0)
                {
                    Console.WriteLine("<Недостаточно товаров в списке>");
                }
                else
                {
                    products[i] = productName + " " + check;
                }
            }
        }
        if (!productExists)
        {
            Console.WriteLine("\nПродукт не существует");
        }
    }
}
