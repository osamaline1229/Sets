using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    internal class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string gender { get; set; }

        public Person(long id, string name, string gender )
        {
            this.Id = id;
            this.Name = name;
            this.gender = gender;
        }

        public override string ToString()
        {
            return ($"name:{Name},gender:{gender}");
        }
    }
}
