using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp
{
    internal class Stringoperation
    {
        public void stringTask()
        {
            string name = "JAYDEEP kotak";
            Console.WriteLine("Original String = " + name);
            Console.WriteLine("Length = " + name.Length);
            Console.WriteLine("Uppercase = " + name.ToUpper());
            Console.WriteLine("Lowercase = " + name.ToLower());
            Console.WriteLine("Contains = " + name.Contains("kotak"));
            Console.WriteLine("index = " + name[0]);
            Console.WriteLine("indexOf = " + name.IndexOf("kotak"));
            Console.WriteLine("indexOf if value not ava;iable in string = " + name.IndexOf("z"));
            Console.WriteLine("substring(8) = " + name.Substring(8));
            Console.WriteLine("substring(8,3) = " + name.Substring(8,3));






        }
    }
}
