namespace Introduction.Exceptions
{
    public class clsDelivery
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }

        public string Address { get; set; }

        public enDeliveryStatus DeliveryStatus { get; set; }
        public clsDelivery(int ID, string CustomerName, string Address)
        {
            this.ID = ID;
            this.CustomerName = CustomerName;
            this.Address = Address;
        }

        public override string ToString()
        {

            return $"   \n{{      \n   ID: {ID}\n   Customer Name: {CustomerName}\n   Address: {Address}\n   {this.DeliveryStatus}\n}}";
        }
    }
}
