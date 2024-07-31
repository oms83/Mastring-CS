using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Attributes
{
    public class Employee
    {
        public Employee(int iD, string firstName, string lastName, short age)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Validate(nameof(Age), 60, 18)]
        public int Age { get; set; }

    }
    public class ValidateAttribute : Attribute
    {
        public ValidateAttribute(string name, int max, int min)
        {
            Name = name;
            Max = max;
            Min = min;
        }

        public string Name { get; set; }
        public int Max {  get; set; }
        public int Min { get; set; }

        
        public bool IsValidRange(object obj)
        {
            var value = (int)obj;
            return value >= Min && value <= Max;    
        }

    }

    public class Errors
    {
        public Errors(string field, string details)
        {
            this.field = field;
            this.massage = details;
        }

        private string field { get; set; }
        private string massage {  get; set; }

        public override string ToString()
        {
            return $"{field}: {massage}";
        }
    }

    public class ReelExample
    {
        public static void run()
        {
            Employee[] employees =
            {
                new Employee(111, "omer", "memes", 24),
                new Employee(113, "ali", "memes", 20),
                new Employee(112, "omer", "memes", 15),
                new Employee(-122, "yusuf", "memes", 33),
            };

            var errors = new List<Errors>();

            foreach (var employee in employees)
            {
                var properties = employee.GetType().GetProperties();

                foreach (var property in properties)
                {
                    var validationAttribute = property.GetCustomAttribute<ValidateAttribute>();
                    if (validationAttribute != null)
                    {
                        var value = property.GetValue(employee);

                        if (!validationAttribute.IsValidRange(value))
                        {
                            errors.Add(new Errors(validationAttribute.Name, $"age should be between {validationAttribute.Min} - {validationAttribute.Max}"));
                        }


                    }
                }
            }

            errors.ForEach(e => Console.WriteLine(e));

        }
    }
}
