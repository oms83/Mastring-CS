using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Exceptions
{

    public enum enDeliveryStatus
    {
        UNKNOWN,
        PROCESSED,
        SHIPPED,
        INTRANSIT,
        DELIVERED,
    }

    internal class Example2
    {
        public static void run()
        {
            clsDelivery delivery1 = new clsDelivery(1, "Omer", "Turkey, Trabzon");
            clsDeliveryService deliveryService = new clsDeliveryService();
            
            deliveryService.Start(delivery1);

            Console.WriteLine(delivery1.ToString());
        }
    }
}
