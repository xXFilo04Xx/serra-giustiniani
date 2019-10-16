using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serra_giustiniani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci i gradi della serra: ");
            double statoserra = int.Parse(Console.ReadLine());
            if (statoserra < 5)
            {
                Console.WriteLine("serra irrecuperabile");
            }else
            {
                if (statoserra > 18)
            {
                Console.WriteLine("la serra è in condizioni ottimali");
            }else
            {
                Console.WriteLine("la serra è in condizioni critiche");
            }
            }
            
            Console.ReadLine();
        }
    }
}
