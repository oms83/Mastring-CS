using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Nuget_Packages_and_Packaging
{
    public class FBComment
    {
        public string Owner { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public override string ToString()
        {
            /*
            
                ###                         Default
            
                "Bob Johnson"
                "The dependency injection in ASP.NET Core is very powerful."
                                                        2024-01-15 01:30

                "Mary Williams"
                "Entity Framework Core simplifies database operations."
                                                        2021-06-30 02:10

                "David Brown"
                "I appreciate the modularity of ASP.NET Core."
                                                        2020-09-12 03:25



                ###                         Humanize

                "Bob Johnson"
                "The dependency injection in ASP.NET Core is very powerful."
                                                        6 months ago

                "Mary Williams"
                "Entity Framework Core simplifies database operations."
                                                        3 years ago

                "David Brown"
                "I appreciate the modularity of ASP.NET Core."
                                                        3 years ago

                "Linda White"
                "Razor Pages make building web applications quick and easy."
                                                        one year from now
 
            */
            //return $"\"{Owner}\"\n\"{Comment}\"\n\t\t\t\t\t{CreatedAt.ToString("yyyy-MM-dd hh:mm")}\n";
            return $"\"{Owner}\"\n\"{Comment}\"\n\t\t\t\t\t{CreatedAt.Humanize()}\n";
        }

    }

    public class Example1
    {
        public static void run()
        {
            FBComment[] comments =
               {
                    new FBComment
                    {
                        Owner = "Omer MEMES",
                        Comment = "I Think ASP NET CORE is the most powerful Web Framework",
                        CreatedAt = new DateTime(2024, 07, 22, 10, 50, 34)
                    },
                    new FBComment
                    {
                        Owner = "Alice Smith",
                        Comment = "Blazor is a game changer for C# developers!",
                        CreatedAt = new DateTime(2023, 05, 18, 11, 15, 45)
                    },
                    new FBComment
                    {
                        Owner = "John Doe",
                        Comment = "I love the performance improvements in .NET 6.",
                        CreatedAt = new DateTime(2022, 03, 22, 12, 05, 20)
                    },
                    new FBComment
                    {
                        Owner = "Jane Roe",
                        Comment = "SignalR makes real-time communication so easy.",
                        CreatedAt = new DateTime(2025, 11, 05, 12, 45, 10)
                    },
                    new FBComment
                    {
                        Owner = "Bob Johnson",
                        Comment = "The dependency injection in ASP.NET Core is very powerful.",
                        CreatedAt = new DateTime(2024, 01, 15, 13, 30, 55)
                    },
                    new FBComment
                    {
                        Owner = "Mary Williams",
                        Comment = "Entity Framework Core simplifies database operations.",
                        CreatedAt = new DateTime(2021, 06, 30, 14, 10, 05)
                    },
                    new FBComment
                    {
                        Owner = "David Brown",
                        Comment = "I appreciate the modularity of ASP.NET Core.",
                        CreatedAt = new DateTime(2020, 09, 12, 15, 25, 15)
                    },
                    new FBComment
                    {
                        Owner = "Linda White",
                        Comment = "Razor Pages make building web applications quick and easy.",
                        CreatedAt = new DateTime(2026, 04, 21, 16, 40, 50)
                    },
                    new FBComment
                    {
                        Owner = "James Green",
                        Comment = "The middleware pipeline in ASP.NET Core is very flexible.",
                        CreatedAt = new DateTime(2027, 08, 10, 17, 55, 30)
                    },
                    new FBComment
                    {
                        Owner = "Patricia Black",
                        Comment = "I enjoy the cross-platform capabilities of .NET Core.",
                        CreatedAt = new DateTime(2023, 02, 28, 18, 20, 25)
                    },
                    new FBComment
                    {
                        Owner = "Michael Young",
                        Comment = "The community support for ASP.NET Core is fantastic.",
                        CreatedAt = new DateTime(2022, 12, 14, 19, 05, 40)
                    }
                };

            foreach (FBComment comment in comments)
            {
                Console.WriteLine(comment);
            }
        }

    }
}
