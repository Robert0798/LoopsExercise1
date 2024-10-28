using System.Threading.Channels;

namespace LoopsDemo;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("for loop");

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("1------");

        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("2------");

        for (int i = 15; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("3------");
        
        for (int i = 0; i <= 10; i+=2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("4-------");
        
        for (int i = 0; i <= 20; i+=10)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("5--------");

        for (int i = 0; i <= 30; i +=2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("6--------");

        for (int i = 20; i >= 0; i -= 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("7---------");

        for (int i = 40; i >= 0; i -= 4)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("8----------");

        for (int i = 3; i <= 25; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("9----------");

        for (int i = 50; i >= 0; i -= 10)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("10-----------");

        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("11---------");

        for (int i = 0; i <= 100; i += 20)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("12----------");

        for (int i = 10; i >= 0; i -= 5)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("13----------");

        for (int i = 1000; i >= 100; i -= 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("14------------");

        for (int i = 3; i <= 60; i += 12)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("15-------------");
        
        
    }
    
}