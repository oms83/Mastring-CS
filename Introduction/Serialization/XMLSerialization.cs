using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Introduction.Serialization
{
    public class Employee
    {
        public readonly int Id;

        public Employee(int id, string firstName, string lastName, string[] benefits)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Benefits = benefits;
        }
        public Employee()
        {
            
        }
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string []Benefits {  get; set; }


        public override string ToString()
        {
            return $"ID: {Id}\nFull Name: {FirstName} {LastName}\nBenefits: [{string.Join(", ", Benefits)}]";
        }
    }

    public class XMLSerialization
    {
        public static void run()
        {
            Employee employee = new Employee(1, "Omer", "MEMES", new[] { "Pension", "Health Insurance" });
            
            string result = SerializeToXMLString(employee);

            File.WriteAllText("xmlDecument.xml", result);
            
            Console.WriteLine(result);


            Console.WriteLine("\n-----------------------------------\n");

            string Content = File.ReadAllText("xmlDecument.xml");
            Employee employee2 = DeserializeXMLString(Content);
            Console.WriteLine(employee2);
        }
        private static Employee DeserializeXMLString(string xmlContent)
        {
            var xmlSerializer = new XmlSerializer(typeof(Employee));
            Employee employee = null;

            using (StringReader reader = new StringReader(xmlContent))
            {
                employee = xmlSerializer.Deserialize(reader) as Employee;
            }

            return employee;
        }
        private static string SerializeToXMLString(Employee employee)
        {
            string result = "";

            var xmlSerializer = new XmlSerializer(typeof(Employee));
            //var xmlSerializer = new XmlSerializer(employee.GetType());

            using (var sw = new StringWriter())
            {
                using (var xw = XmlWriter.Create(sw, new XmlWriterSettings { Indent = true }))
                {
                    xmlSerializer.Serialize(xw, employee);
                    result = sw.ToString();
                }
            }

            return result;
        }
  

    }
}
