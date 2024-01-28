using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class FileSystemComponent
    {
        public string Name { get; set; }

        public FileSystemComponent(string name)
        {
            Name = name;
        }

        public abstract void Display();
    }
}
