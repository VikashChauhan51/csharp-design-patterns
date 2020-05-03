using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singleton factory
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class Singleton<T> where T : class, new()
    {
        /// <summary>
        /// Private constructor
        /// </summary>
        Singleton()
        {
        }
        /// <summary>
        /// Explicit static constructor to tell C# compiler not to mark type as before field init.
        /// </summary>
        static Singleton()
        {
        }
        private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());

        // Public static property to get the object
        public static T Instance
        {
            get { return lazy.Value; }
        }
    }
}
