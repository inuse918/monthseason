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
            Console.WriteLine("태어난 달을 입력하세요: ");
            string test = Console.ReadLine();
            string temp = Regex.Replace(test, @"\D", ""); // \D는 숫자가 아닌 문자열을 뜻함.
            Console.WriteLine(temp);
        }
    }
}
