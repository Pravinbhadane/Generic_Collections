
using Generic_Collections;

public class Program
{
    static void Main(string[] args)
    {
          List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        list.Sort();
        Console.WriteLine("After Sort");
        foreach (int i in list)
        {
            Console.Write(i+" ");
        }
         list.Remove(3);
        Console.WriteLine("\nAfter Remove ");
        foreach (int i in list)
        {
            Console.Write(i+" ");
        }

        List<String> list2 = new List<String>();

        list2.Add("a");
        list2.Add("b");
        list2.Add("c");
        list2.Add("d");

        Console.WriteLine("\nAfter Sort");
        list2.Sort();
        foreach (string i in list2)
        {
            Console.Write(i+" ");
        }

        Console.WriteLine("\nAfter Remove");
        list2.Remove("c");
        foreach (string i in list2)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine("\n");
        Console.WriteLine("*******Product List********");

        List<Product> products = new List<Product>();
        products.Add(new Product { Id = 1, Name = "Laptop", Price = 60000 });
        products.Add(new Product { Id=2, Name= "Mobile", Price=30000});
        products.Add(new Product { Id=3, Name= "TV", Price=40000});
        products.Add(new Product { Id=4, Name= "AC", Price=500000});

         
        foreach (Product product in products)
        {
            Console.Write($"ID: {product.Id},  Name: {product.Name}, Price: {product.Price}");
            Console.WriteLine();
        }
    }
}