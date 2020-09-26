using System.ComponentModel;

namespace Tech_Boost_2020
{
    class Person
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Person(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public override string ToString()
        {
            return Name + " -- " + Role;
        }
    }
}
