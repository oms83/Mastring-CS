using System;

namespace Introduction.Exceptions
{
    public class clsDeliveryService
    {
        private readonly Random random = new Random();
        public void Start(clsDelivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch (AccidentException ex)
            {
                // Ducking Excetion means sending the exception that occurred in a method to the
                // method that called that method


                // this means the exception will be shown here => "deliveryService.Start(delivery1);"

                //Console.WriteLine($"{ex.Message} Address: {ex.Location}");
                throw ex; 
            }
            catch (InvalidAddressException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Deliver fails due to: {ex.Message}");
                delivery.DeliveryStatus = enDeliveryStatus.UNKNOWN;
            }
            catch (Exception ex) when (ex.Source == "Mastring CS")
            {
                // Exception class it is a general class can cath all excetion in the programm
                //Swallow exception means hide the exception method or prevent it to display on the screen

                Console.WriteLine($"{ex.Message}");
                //Console.WriteLine($"{ex.Message}"); Swallow ابتلاع
            }
            finally
            {
                Console.WriteLine("End");
            }
        }

        private void Process(clsDelivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("unable to process the item");
            }
            delivery.DeliveryStatus = enDeliveryStatus.PROCESSED;
        }

        private void Ship(clsDelivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Parcel is damaged during the loading process");
            }
            delivery.DeliveryStatus = enDeliveryStatus.SHIPPED;
        }

        private void Transit(clsDelivery delivery)
        {
            FakeIt("On Its Way");
            if (random.Next(1, 2) == 1)
            {
                throw new AccidentException("Turkey, Trabzon, Ortahisar, Pelitli, Elmas Sk.", "ACCIDENT !!!");
            }
            delivery.DeliveryStatus = enDeliveryStatus.INTRANSIT;
        }
        private void Deliver(clsDelivery delivery)
        {
            FakeIt("Delivering");
            if (random.Next(1, 2) == 1)
            {
                throw new InvalidAddressException(delivery.Address, $"{delivery.Address} is invalid !");
            }
            delivery.DeliveryStatus = enDeliveryStatus.DELIVERED;
        }
        private void FakeIt(string Title)
        {
            Console.Write(Title);
            
            Console.Write(".");
            System.Threading.Thread.Sleep(300);

            Console.Write(".");
            System.Threading.Thread.Sleep(300);

            Console.Write(".");
            System.Threading.Thread.Sleep(300);

            Console.WriteLine(".");
            System.Threading.Thread.Sleep(300);
        }
    }
}
