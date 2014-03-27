using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace NativeDLL
{
    public interface ITest
    {
        bool isEqual(string value1, string value2);
    }

    [ClassInterface(ClassInterfaceType.None)]
    public class Test : ITest
    {
        public Test() { }

        public bool isEqual(string value1, string value2)
        {
            return value1.Equals(value2);
        }
    }
}
