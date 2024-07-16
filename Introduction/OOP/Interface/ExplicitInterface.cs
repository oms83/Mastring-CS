using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Interface
{
    public interface IMove
    {
        void Move();
        void Stop();

        /*
            in version 8 it is enable
            void Turn()
            {

            }
        */
    }

    public class Car : IMove
    {
        void IMove.Move()
        {
            throw new NotImplementedException();
        }

        void IMove.Stop()
        {
            throw new NotImplementedException();
        }
    }

    internal class ExplicitInterface
    {
        public static void run()
        {
            Car c  = new Car();
            
        }
    }
}
