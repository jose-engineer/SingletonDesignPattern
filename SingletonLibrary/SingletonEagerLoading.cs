using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary {
    public sealed class SingletonEagerLoading {
        private static int counter = 0;
        private static readonly SingletonEagerLoading instance = new SingletonEagerLoading(); // update to readonly and create new instance        

        public static SingletonEagerLoading getInstance
        {
            get
            {
                return instance; //return the instance directly without locking
            } //CLR takes care of the variable initialization and its thread safety
        }

        private SingletonEagerLoading() {
            counter++;
            Console.WriteLine("Contador: " + counter.ToString());
        }

        public void PrintDetails(string msg) {
            Console.WriteLine(msg);
        }
    }
}
