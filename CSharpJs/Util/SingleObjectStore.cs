using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharpJs.Util
{
    public class SingleObjectStore : Singleton<SingleObjectStore>
    {
        private Dictionary<Type, List<object>> dicObject = new Dictionary<Type, List<object>>();

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Register(object obj)
        {
            if (dicObject.ContainsKey(obj.GetType()))
            {
                dicObject[obj.GetType()].Add(obj);
            }
            else
            {
                dicObject[obj.GetType()] = new List<object>();
                dicObject[obj.GetType()].Add(obj);
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void UnRegister(object obj)
        {
            if (dicObject.ContainsKey(obj.GetType()))
            {
                dicObject[obj.GetType()].Add(obj);
                dicObject[obj.GetType()].Remove(obj);
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public object Find(Type type)
        {
            if (dicObject.ContainsKey(type))
            {
                return dicObject[type].Find((x) =>
                {
                    return x.GetType().Equals(type);
                });
            }

            return null;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public List<object> FindAll(Type type)
        {
            if (dicObject.ContainsKey(type))
            {
                return dicObject[type].FindAll((x) =>
                {
                    return x.GetType().Equals(type);
                });
            }

            return null;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public int Count()
        {
            int count = 0;
            foreach (var item in dicObject)
            {
                count += item.Value.Count;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void DebugPrint()
        {
            foreach (var item in dicObject)
            {
                item.Value.ForEach((x) =>
                {
                    Debug.WriteLine(x.GetType().FullName);
                });

            }
        }
    }
}
