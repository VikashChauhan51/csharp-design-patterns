using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class MyClass
    {
        public void Print()
        {
            Console.WriteLine("MyClass");
        }
    }
    public class Demo
    {
        public void Print()
        {
            Console.WriteLine("Demo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.For(0, 10, i =>
            {
                Demo s1 = Singleton<Demo>.Instance;
                Demo s2 = Singleton<Demo>.Instance;
                MyClass s3 = Singleton<MyClass>.Instance;
                MyClass s4 = Singleton<MyClass>.Instance;
                if (s1.Equals(s2))
                {
                    Console.WriteLine($"Objects are the same instance type:{typeof(Demo)}");
                    s1.Print();
                }
                if (s3.Equals(s4))
                {
                    Console.WriteLine($"Objects are the same instance type:{typeof(MyClass)}");
                    s3.Print();
                }
            });
            Console.ReadKey();

           
        }
        private static PersonSingleton SimpleSingleton()
        {
           
         return PersonSingleton.GetInstance;
          
        }
        
    }
}
