using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecusionPeyushDemo
{
    internal class recsionDemo
    {
        int n=1;
        public void display1()
        {
            display2();
            n = n * n;
            Console.WriteLine("display1");
        }
        public void display2()
        {
           

            display3();
            n = n * n;
            Console.WriteLine("display2");
        }
        public void display3()
        {
            
            display4();
            n = n * n;
            Console.WriteLine("display3");
        }
        public void display4()
        {
            n = 2;
            Console.WriteLine("display4");
        }

        ////public static int getfactorail(int n)
        ////{
        ////    if (n == 1 || n == 0)
        ////    {
        ////        return 1;
        ////    }

        ////    int fact = 1;
        ////    for (int i = n; i >= 1; i--)
        ////    {
        ////        fact *= i;
        ////    }
        ////    return fact;
        ////}

        ////public static int getfactorailwithrecusrion(int n)
        ////{
        ////    if(n==1 || n == 0)
        ////    {
        ////        return 1;
        ////    }

        ////    return n * getfactorailwithrecusrion(n - 1);
        ////}

    }
}
