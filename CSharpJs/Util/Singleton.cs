using System;

namespace CSharpJs.Util
{
    public class Singleton<T> where T : class, new()
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T());

        protected Singleton() { }

        public static T Instance()
        {
            return _instance.Value;
        }
    }
}
