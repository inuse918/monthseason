using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("태어난 달을 입력하세요: ");
            //string test = Console.ReadLine();
            //string temp = Regex.Replace(test, @"\D", ""); // \D는 숫자가 아닌 문자열을 뜻함.
            //Console.WriteLine(temp);

            string month = Console.ReadLine();
            string temp = Regex.Replace(month, @"\D", "");
            int monthChange = int.Parse(temp);

            switch (monthChange)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄에 태어나셨네요");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름에 태어나셨네요");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을에 태어나셨네요");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울에 태어나셨네요");
                    break;

                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;
            }
        }
    }
}
