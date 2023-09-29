using System;
using System.Diagnostics.Metrics;

namespace Uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? \nSvara ett \"j\" för ja, eller ett \"n\" för nej.");
            string gymnasie = Console.ReadLine();

            Console.WriteLine("Hur gammal är du? Svara med ett heltal.");
            int age = int.Parse(Console.ReadLine());

            if (gymnasie == "j" && age < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
            Console.ReadKey();
        }
    }
}
