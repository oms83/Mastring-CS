namespace Oms.NumberSystem.Models
{
    public class BinarySystem : Base
    {
        public BinarySystem(string value)
        {
            value.Guard("01", NumberBase.BINARY);
            this.Value = value;
        }
    }
    public class DecimalSystem : Base
    {
        public DecimalSystem(string value)
        {
            value.Guard("0123456789", NumberBase.BINARY);
            this.Value = value;
        }
    }
}
