using Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        //Ex 1
        static void Square(int size, char syb)
        {
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write($"{syb} ");
                }
                Console.WriteLine();
            }
        }

        static bool isPalindrom(int num)
        {
            string str = num.ToString();
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string reversedStr = new string(ch);
            return str == reversedStr;
        }

        static int[] FilterArray(int[] startArr, int[] filteredArr) 
        {
            int size = 0;
            for(int i = 0; i < startArr.Length; i++)
            {
                if (!(filteredArr.Contains(startArr[i]))){
                    size++;
                }
            }
            int[] res = new int[size];
            int temp = 0;
            for (int i = 0; i < startArr.Length; i++)
            {
                if (!(filteredArr.Contains(startArr[i])))
                {
                    res[temp] = startArr[i];
                    temp++;
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            //Ex 1
            Program.Square(5, 'a');

            //Ex 2
            int num = 123321;
            Console.WriteLine($"Number \"{num}\" is {(isPalindrom(num)? "pallindrom" : "not pallindrom")}");
            int num1 = 234132;
            Console.WriteLine($"Number \"{num1}\" is {(isPalindrom(num1) ? "pallindrom" : "not pallindrom")}");
            int num2 = 2344;
            Console.WriteLine($"Number \"{num2}\" is {(isPalindrom(num2) ? "pallindrom" : "not pallindrom")}");
            int num3 = 111111;
            Console.WriteLine($"Number \"{num3}\" is {(isPalindrom(num3) ? "pallindrom" : "not pallindrom")}");

            //Ex 3
            int [] res = FilterArray((new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), new int[2] { 1, 3 });
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Ex 4
            try
            {
                WebSite site1 = new WebSite("Whatsapp", "https://www.whatsapp.com", "With private messaging and calling, you can \nbe yourself, speak freely and feel close ", "Hekllo");
                site1.PrintInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
