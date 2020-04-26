using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singleton Design Pattern is to ensures that only one instance of a particular class is going to be created 
    /// and then provide simple global access to that instance for the entire application.
    /// </summary>
    public sealed class PersonSingleton
    {
        private static int counter = 0;
        private static PersonSingleton instance = null;
        private PersonSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
       
        public static PersonSingleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new PersonSingleton();
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
