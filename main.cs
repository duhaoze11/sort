using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, t;
            string[] ch;
            int[] a;
            string s = Console.ReadLine();
             
            ch = s.Split(' ');
            n = ch.Length;
            a = new int[n];
            try
            {
                for (int i = 0; i <= n - 1; i++)
                    a[i] = int.Parse(ch[i]);
            }
            catch
            {
                Console.WriteLine("the input is illegal!");
                System.Console.Read();
                return;
            }
            for (int i = 0; i <= n - 2; i++)
                for (int j = i; j <= n - 1; j++)
                    if (a[i] > a[j])
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
            for (int i = 0; i <= n - 1; i++)
                Console.WriteLine(a[i]);
            System.Console.Read();
        }
    }
}