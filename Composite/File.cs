using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class File:FileSystemComponent
    {
        public File(string name) : base(name) { }

        public override void Display()
        {
            Console.WriteLine($"File: {Name}");
        }
    }
}
