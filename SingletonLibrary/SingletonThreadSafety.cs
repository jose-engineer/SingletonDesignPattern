using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary {
    public sealed class SingletonThreadSafety {

        private static int counter = 0;
        private static SingletonThreadSafety instance = null;
        private static readonly object obj = new object(); // log object

        public static SingletonThreadSafety getInstance
        {
            get
            {
                if (instance == null) {
                    lock (obj) { //only one thread can enter into this code block at a given point of time
                        if (instance == null) {
                            instance = new SingletonThreadSafety();
                        }
                    }
                }
                return instance;
            }
        }

        private SingletonThreadSafety() {
            counter++;
            Console.WriteLine("Contador: " + counter.ToString());
        }

        public void PrintDetails(string msg) {
            Console.WriteLine(msg);
        }

    }
}
