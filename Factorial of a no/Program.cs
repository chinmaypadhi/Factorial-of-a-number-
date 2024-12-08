using System;
using System.Threading.Tasks;

namespace Factorial_of_a_no
{
    class Program
    {

        static async void  factorial(int no)
        {
        Task.Run(() =>
              {

                  int fact = 1;

                  for (int i = 1; i <= no; i++)
                  {
                      fact = fact * i;
                  }

                  Console.WriteLine(fact);
              });
        }
        static void Main(string[] args)
        {
            factorial(3);
            Console.ReadLine();
        }
    }
}
