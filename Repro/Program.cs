using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repro
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<string>();
            hashSet.Add("ada");
            hashSet.Add("ada1");
            hashSet.Add("ada2");
            IReadOnlyCollection<string> hash = (IReadOnlyCollection<string>)hashSet;
            Console.WriteLine(hash.First());
        }
    }
}
