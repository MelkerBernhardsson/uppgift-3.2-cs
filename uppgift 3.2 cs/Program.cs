using System;

namespace uppgift32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Y/N ");
            string användare1 = Console.ReadLine();
            Console.WriteLine("Hur gammal är du? svara i antal år");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 22 && användare1 == "Y") 
                Console.WriteLine("vi vill gärna anställa dig");
            
            else
                Console.WriteLine("vi letar tyvärr efter annan personal");
        }
    }
}
