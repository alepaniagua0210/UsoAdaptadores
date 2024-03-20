using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAdapter
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        // constructor sin parametros o inicializado por defecto
        public Person() : this(0, string.Empty, 0, 0){ }

        // constructor sobrecargado
        public Person(int id, string name, int age, double height)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
        }
    }
}
