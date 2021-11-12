using System;

namespace U2UPeople
{
    public enum GenderType
    {
        Male,
        Female,
        Unknown
    }
    public class Person : IComparable
    {
        public Person(string name, int age, GenderType gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public Person(string name, int age) : this(name, age, GenderType.Unknown) { }

        public Person() { }
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set 
            { 
                if(value >= 18)
                {
                    age = value;
                }
            }
        }

        public bool IsRetired { 
            get
            {
                return age >= 65 ? true : false;
            }
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name} - Age: {Age} - Gender: {Gender} - Retired? {IsRetired}";
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() != this.GetType())
            {
                return false;
            }
            Person p = (Person)obj;
            return p.Name == Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            if (obj.GetType() == GetType())
            {
                return Name.CompareTo(p.Name);
            }
            return 0;
        }
    }
}
