using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Enumerators
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(int Id, string Name, string Department)
        {
            this.Name = Name;
            this.Department = Department;
            this.Id = Id;
        }

        public override string ToString()
        {
            return $"ID: {Id}   Name: {Name}   Department: {Department}";
        }

        // By default, it compares object references
        //public override bool Equals(Object obj)
        //{
        //    if (obj == null || !(obj is Employee))
        //    {
        //        return false;
        //    }

        //    return this.Id == (obj as Employee).Id &&
        //        this.Name == (obj as Employee).Name &&
        //        this.Department == (obj as Employee).Department;
        //}

        // By default, it compares object references

        public override bool Equals(Object obj)
        {
            if ( obj == null || !(obj is Employee))
            {
                return false;
            }

            var emp = (obj as Employee);

            return this.Id == emp.Id &&
                this.Name == emp.Name &&
                this.Department == emp.Department;
        }

        public static bool operator ==(Employee lft, Employee rght) => lft.Equals(rght);
        public static bool operator !=(Employee lft, Employee rght) => !lft.Equals(rght);

        /*
            If two objects are equal, it means that their hash codes are equal
            If hash codes of two objects are equal, it not mean that the objects are equal
        */
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Id.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Department.GetHashCode();

            return hash;
        }
    }

    internal class Equals_GetHash
    {
        public static void run()
        {
            Employee employee1 = new Employee(1, "Omer MEMES", "Software Engineer");
            Employee employee2 = new Employee(1, "Omer MEMES", "Software Engineer");

            Console.WriteLine(employee2 == employee1);
            Console.WriteLine(employee2.Equals(employee1));

            Console.WriteLine($"hash code: {employee2.GetHashCode()}");
            Console.WriteLine($"hash code: {employee1.GetHashCode()}");
        }
    }
}
