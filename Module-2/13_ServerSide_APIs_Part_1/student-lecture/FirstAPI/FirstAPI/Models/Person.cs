using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HeightInches { get; set; }

        public Person(int id, string name, int heightInches)
        {
            this.Id = id;
            this.Name = name;
            this.HeightInches = heightInches;

        }

    }
}
