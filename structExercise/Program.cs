using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number randomObject = new Number();
            randomObject.Amount = 32.3m;
            Console.WriteLine(randomObject.Amount);
            Console.ReadLine();

        }
    }
}
