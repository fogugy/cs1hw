using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public static class Mapper
    {
        public static T Parse<T>(string sourceStr, char splitter = ' ') where T : ISetAttribute, new()
        {
            T obj = new T();
            obj.SetAttributes(sourceStr.Split(splitter));

            return obj;
        }

        public static List<T> ParseList<T>(List<string> sourceStrList, char splitter = ' ') where T : ISetAttribute, new()
        {
            List<T> list = new List<T>();
            foreach(string s in sourceStrList)
            {
                list.Add(Parse<T>(s));
            }
            return list;
        }
    }
}