using System.Collections.Generic;

namespace XFLab.Models
{
    public class AnimalGroup : List<Monkey>
    {
        public string Name { get; private set; }

        public AnimalGroup(string name, List<Monkey> animals) : base(animals)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
