using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary {
    public sealed class Singleton { //sealed restricts the inheritance,
                                    //if sealed not used you can create multiple instance if you use nested classes
        private static int counter = 0;
        private static Singleton instance = null;

        public static Singleton getInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        } // property that creates instances, public is used to return only one instance of the class leveraging on the private property

        private Singleton() { //"private" restrict multiple intance creation
            counter++;
            Console.WriteLine("Contador: " + counter.ToString());
        } //"private" ensures that object is not instantiated other than with in the class itself

        public void PrintDetails(string msg) {
            Console.WriteLine(msg);
        }

    }

    public static class Conversion {
        public static double ToFarenheit(double celsius) {
            return (celsius * 9 / 5) + 32;
        }
    }
}
