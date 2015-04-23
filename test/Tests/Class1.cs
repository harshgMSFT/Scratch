using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class SampleTests
    {
        [Fact]
        public void Test()
        {
            var hashSet = new HashSet<string>();
            hashSet.Add("adad");
            hashSet.Add("adad1");
            hashSet.Add("adad2");

            var hash = (IReadOnlyCollection<string>)hashSet;
            Console.WriteLine(hash.First());
            Assert.Equal(2, hash.Count);
        }
    }
}
