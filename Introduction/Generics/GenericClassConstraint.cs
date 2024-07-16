using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Generics
{
    // where T : constraint1, constraint2, ...
    //  new() avoid string generic 
    public class Example<T> where T : class, new()
    {
        List<T> _list = new List<T>();

        public void Add(T item) => _list.Add(item);
        public void Clear() => _list.Clear();
        public void RemoveAt(int index) => _list.RemoveAt(index);

        public override string ToString() => string.Join(", ", _list);
    }
    public class clsPerson
    {
        public string Name { get; set; }
        public short Age { get; set; }

        public clsPerson()
        {
            
        }
        public clsPerson(string name, short age)
        {
            this.Age = age;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }


    }
    internal class GenericClassConstraint
    {
        public static void run()
        {
            //Example<int> numbers = new Example<int>(); integer data type is not class


            /*
                after add the where T:new() we cannot use the string class   
                السرتينغ هو الكلاس في من اساس اللغة لذلك مع استخدام نيو ماعاد منقدر نستخدمه
                                                                                      كجنرك
                
                Example<string> names = new Example<string>();
                names.Add("Omer");
                names.Add("Ali");

                Console.WriteLine(names.ToString());
            */

            /*
                يجب الا نستخدم براميترايز كوستركتر في الكلاس مشان النيو ما ترفض الكلاس
                
                if we use the parameterize constructor we should add the parameter less 
                consturctor other than this we will take an error
            */
            Example<clsPerson> persons = new Example<clsPerson>();
            persons.Add(new clsPerson { Name = "omer", Age = 24 });
            persons.Add(new clsPerson { Name = "ali", Age = 20 });
            Console.WriteLine(persons.ToString());
        }
    }
}
