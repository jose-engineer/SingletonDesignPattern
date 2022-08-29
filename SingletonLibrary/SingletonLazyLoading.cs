using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary {
    public sealed class SingletonLazyLoading {

        private static int counter = 0;
        private static readonly Lazy<SingletonLazyLoading> instance =
            new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());//Wrap the singleton object in a Lazy manner

        public static SingletonLazyLoading getInstance
        {
            get
            {
                return instance.Value; //access the Singleton object using "Value"
            }
        }

        private SingletonLazyLoading() {
            counter++;
            Console.WriteLine("Contador: " + counter.ToString());
        }

        public void PrintDetails(string msg) {
            Console.WriteLine(msg);
        }

    }
}
