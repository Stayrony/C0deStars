using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CodeStars01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            BigInteger numOfPermutations;
            BigInteger hours;

            Console.WriteLine("Please, input number of participants:");
            num = Convert.ToInt32(Console.ReadLine());

            try
            {
                numOfPermutations = Factorial(num);
                hours = numOfPermutations * 10 / 3600;
                Console.WriteLine("We need {0} hours to review all the permutations.", hours);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.ReadKey();
        }

        static BigInteger Factorial(BigInteger num)
        {
            if (num < 1)
            {
                throw new Exception("The number must be positive!");
            }
            if (num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);

        }
    }
}
