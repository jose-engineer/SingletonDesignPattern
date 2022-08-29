using SingletonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEstud = Singleton.getInstance;
            fromEstud.PrintDetails("From Student");

            Singleton fromEmployee = Singleton.getInstance;
            fromEmployee.PrintDetails("From Employee");

            double result = Conversion.ToFarenheit(7);
            Console.WriteLine(result);

            Console.ReadLine();


            //SingletonThreadSafety fromEstud = SingletonThreadSafety.getInstance;
            //fromEstud.PrintDetails("From student");

            //SingletonThreadSafety fromEmployee = SingletonThreadSafety.getInstance;
            //fromEmployee.PrintDetails("From employee");

            //double result = Conversion.ToFarenheit(7);
            //Console.WriteLine(result);

            //Console.ReadLine();


            //SingletonEagerLoading fromEstud = SingletonEagerLoading.getInstance;
            //fromEstud.PrintDetails("From student");

            //SingletonEagerLoading fromEmployee = SingletonEagerLoading.getInstance;
            //fromEmployee.PrintDetails("From employee");

            //double result = Conversion.ToFarenheit(7);
            //Console.WriteLine(result);

            //Console.ReadLine();


            //SingletonLazyLoading fromEstud = SingletonLazyLoading.getInstance;
            //fromEstud.PrintDetails("From student");

            //SingletonLazyLoading fromEmployee = SingletonLazyLoading.getInstance;
            //fromEmployee.PrintDetails("From employee");

            //double result = Conversion.ToFarenheit(7);
            //Console.WriteLine(result);

            //Console.ReadLine();
        }
    }
}
