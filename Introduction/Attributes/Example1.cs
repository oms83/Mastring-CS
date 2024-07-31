using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Attributes
{
    [DebuggerDisplay("No: {no}, Title:{title}")]
    public class Update
    {
        private int no;
        private string title;

        public Update(int no, string title)
        {
            this.no = no;
            this.title = title;
        }

        public override string ToString()
        {
            return $"no: {this.no} - title: {this.title}";
        }
    }

    public class UpdateProcessor
    {
        //    error:
        //     true if the obsolete element usage generates a compiler error; false if it generates
        //     a compiler warning.

        [ObsoleteAttribute("this method will be not supported in the next release consider using DownloadAndInstall() instead", false)]
        public static void Download(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }

        [ObsoleteAttribute("this method will be not supported in the next release consider using DownloadAndInstall() instead", false)]
        public static void Install(Update[] updates)
        {

            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Install {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }
    }

    public class Example1
    {
        public static void run()
        {
            Update[] updates =
            {
                new Update(1, "security update"),
                new Update(2, "ui enhancements"),
                new Update(3, "No. of bug fixes update"),
                new Update(4, "security update"),
            };

            UpdateProcessor.Download(updates);
            UpdateProcessor.Install(updates);
        } 
    }
}
