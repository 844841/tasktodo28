using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktodo28
{
    class Program
    {
        enum Digits { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            StringBuilder numberInWords = InWords(Reverse(num));
            Console.WriteLine("{0} in Words : {1}", num, numberInWords);
            Console.Read();
        }

        public static StringBuilder InWords(int num)
        {

            StringBuilder numberInWords = new StringBuilder();
            while (num > 0)
            {
                int rem = num % 10;
                switch (rem)
                {
                    case 0:
                        numberInWords.Append(" Zero ");
                        break;
                    case 1:
                        numberInWords.Append(" One ");
                        break;
                    case 2:
                        numberInWords.Append(" Two ");
                        break;
                    case 3:
                        numberInWords.Append(" Three ");
                        break;
                    case 4:
                        numberInWords.Append(" Four ");
                        break;
                    case 5:
                        numberInWords.Append(" Five ");
                        break;
                    case 6:
                        numberInWords.Append(" Six ");
                        break;
                    case 7:
                        numberInWords.Append(" Seven ");
                        break;
                    case 8:
                        numberInWords.Append(" Eight ");
                        break;
                    case 9:
                        numberInWords.Append(" Nine ");
                        break;

                }
                num = num / 10;
            }
            return numberInWords;
        }

        public static int Reverse(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            return reverse;
        }


    }
}