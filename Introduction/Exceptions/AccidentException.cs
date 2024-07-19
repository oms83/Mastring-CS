using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Exceptions
{
    public class AccidentException : Exception
    {
        public string Location { get; set; }
        public AccidentException(string Location, string Message) : base(Message) 
        {
            this.Location = Location;
        }
    }
}
