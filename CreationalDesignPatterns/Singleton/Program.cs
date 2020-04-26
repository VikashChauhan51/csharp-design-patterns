using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSingleton();
            Console.ReadKey();

           
        }
        private static void SimpleSingleton()
        {
            PersonSingleton fromTeachaer = PersonSingleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            PersonSingleton fromStudent = PersonSingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
