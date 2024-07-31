using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Attributes
{
    // inherited = true that means the sub classes where inherited this class will get this attribute
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class SkillAttribute : Attribute
    {
        public SkillAttribute(string name, int max, int min)
        {
            Name = name;
            Max = max;
            Min = min;
        }

        public string Name { get; set; }
        public int Max {  get; set; }
        public int Min { get; set; }

        public bool IsValid(object obj)
        {
            var value = (int)obj;
            return value <= this.Max && value >= this.Min;
        }
    }
    public class Error
    {
        private string field;
        private string details;

        public Error(string field, string details)
        {
            this.field = field;
            this.details = details;
        }

        public override string ToString()
        {
            return $"{{\"{field}\": \"{details}\"}}";
        }
    }

    public class Player
    {
        public Player(string name, int ballControl, int dribbling, int power, int speed, int passing)
        {
            Name = name;
            BallControl = ballControl;
            Dribbling = dribbling;
            Power = power;
            Speed = speed;
            Passing = passing;
        }

        public string Name { get; set; }


        [Skill(nameof(BallControl), 20, 1)]
        [Skill(nameof(BallControl), 20, 1)] // allow multiple = true
        public int BallControl { get; set; } // 1 - 20
        

        [Skill(nameof(Dribbling), 20, 1)]
        public int Dribbling  { get; set; } // 1 - 20
        
        
        [Skill(nameof(Power), 1000, 1)]
        public int Power { get; set; } // 1 - 1000
        
        
        [Skill(nameof(Speed), 100, 1)]
        public int Speed { get; set; } // 1 - 100

        
        [Skill(nameof(Passing), 4, 1)]
        public int Passing { get; set; } // 1 - 4
    }

    public class Example2
    {
        public static void run()
        {
            Player[] players =
            {
                new Player("omer", 20, 20, 900, 90, 4),
                new Player("ali", 26, 22, 700, 90, 2),
                new Player("yusuf", 24, 20, 1020, 20, 3),
                new Player("osman", 14, 20, 900, 50, 1)
            };
            var errors = new List<Error>();

            foreach (Player player in players)
            {
                // return properties of objcet in the class where that object belongs to this class
                var properties = player.GetType().GetProperties();
                
                foreach (var property in properties)
                {
                    // return type of custom attribute on the properties
                    var skillAttribute = property.GetCustomAttribute<SkillAttribute>();

                    if (skillAttribute != null)
                    {
                        // return the property value of player object 
                        var value = property.GetValue(player);

                        if (!skillAttribute.IsValid(value))
                        {
                            errors.Add(new Error(property.Name, $"{player.Name} Invalid value Accepted is  {skillAttribute.Min} - {skillAttribute.Max}"));
                        }
                    }
                }
            }
            errors.ForEach(error => Console.WriteLine(error));
        }
    }
}
