using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 9, 9, 9, 9, 9};

            foreach (int inp in input)
            {
                Console.Write(" " + Convert.ToString(inp));
            }
            Console.WriteLine();

            input = PlusOne(input);

            foreach (int inp in input)
            {
                Console.Write(" " + Convert.ToString(inp));
            }
            Console.WriteLine();
            Console.Read();


            int[] PlusOne(int[] digits)
            {
                bool flag = false;

                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] != 9)         // это первое или любое другое число и оно не равно 9
                    {
                        digits[i] += 1;
                        return digits;
                    }

                    if (digits[i] == 9 && i == 0)       // если у нас последнее число равно 9 или вообще число равно 9
                    {
                        digits[i] = 0;
                        int[] answer = new int[(digits.Length + 1)];
                        answer[0] = 1;
                        answer.Concat(digits);
                        return answer;
                    }

                    if (digits[i] == 9 && flag == false) //если у нас самое первое число с конца == 9
                    {
                        digits[i] = 0;
                    }

                    if (digits[i] != 9 && flag == true)     //если второе и последующие числа с конца == 9 
                    {
                        digits[i] += 1;
                        return digits;
                    }
                }
                return digits;

            }

        }
    }
}
