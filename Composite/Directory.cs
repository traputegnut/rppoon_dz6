using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Directory:FileSystemComponent
    {
        private List<FileSystemComponent> components = new List<FileSystemComponent>();

        public Directory(string name) : base(name) { }

        public void AddComponent(FileSystemComponent component)
        {
            components.Add(component);
        }

        public void RemoveComponent(FileSystemComponent component)
        {
            components.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine($"Directory: {Name}");
            foreach (var component in components)
            {
                component.Display();
            }
        }
    }
}
