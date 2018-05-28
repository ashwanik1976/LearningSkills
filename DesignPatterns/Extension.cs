using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Extension
    {
        //public static T Create<T>(this T @this)
        //where T : class, new()
        //{
        //    return Utility<T>.Create();
        //}
    }
    public static class Utility<T> where T : class, new()
    {
        static Utility()
        {
            Create = Expression.Lambda<Func<T>>(Expression.New(typeof(T).GetConstructor(Type.EmptyTypes))).Compile();
        }
        public static Func<T> Create { get; private set; }
        
    }

    public sealed class testSealed
    {
        public string CamelCase(string str)
        {
            return str.ToUpperInvariant();
        }
    }

}
