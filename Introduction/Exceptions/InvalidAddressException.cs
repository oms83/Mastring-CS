using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Exceptions
{
    public class InvalidAddressException : Exception
    {
        public string Address { get; set; }
        public InvalidAddressException(string Address, string Message) : base(Message) 
        {
            this.Address = Address;
        }
    }
}
