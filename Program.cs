using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Are you M for Masc or F for Femmale");
            string s = Console.ReadLine();
            if(s == "M" || s == "F"){
                if(s == "M"){
                    Console.WriteLine("Hello Boy");
                }
                else{
                    Console.WriteLine("Hello Girl");
                }
            }
            else{
                Console.WriteLine("Are you member of communit LGBTQ+ ?"); 
            }
        }
    }
}
