using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Runtime.InteropServices;

using Microsoft.Win32;

namespace SwapMouseButton
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        static void Main(string[] args)
        {
            if (args.Length == 0) return;
            switch (args[0])
            {
                case "left":
                    SwapMouseButton(1); 
                    break;
                case "right":
                    SwapMouseButton(1);
                    break;
            }
        }
    }
}
