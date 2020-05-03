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
        /// <summary>
        /// Thread Safe Singleton without using locks
        /// </summary>
        private static readonly Lazy<PersonSingleton> lazy = new Lazy<PersonSingleton>(() => new PersonSingleton());

        /// <summary>
        /// Explicit static constructor to tell C# compiler not to mark type as before field init.
        /// </summary>
        static PersonSingleton()
        {
        }
        /// <summary>
        /// Private constructor
        /// </summary>
        private PersonSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        /// <summary>
        /// Public static property to get the object
        /// </summary>
        public static PersonSingleton GetInstance => lazy.Value;
        /// <summary>
        /// Instance method
        /// </summary>
        /// <param name="message"></param>
        public void PrintDetails(string message)
        {
            for (int i = 0; i < counter; i++)
                Console.WriteLine(message);

        }
    }

    

}
