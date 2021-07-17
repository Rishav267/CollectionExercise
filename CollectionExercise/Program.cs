using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dict = new Dictionary<string,int>();
            for(int i=0;i<args.Length;i++)
            {
                if(dict.ContainsKey(args[i]))
                {
                    dict[args[i]]++;
                }
                else
                {
                    dict[args[i]] = 1;
                }
            }
            //dict = dict.OrderBy(Key => Key.Key);
            foreach(KeyValuePair<string,int> k in dict.OrderBy(Key => Key.Key))
            {
                Console.WriteLine("key = {0}, Value = {1}", k.Key, k.Value);
            }
        }
    }
}
