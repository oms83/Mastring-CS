namespace Oms.NumberSystem.Models
{
    public class OctalSystem : Base
    {
        public OctalSystem(string value)
        {
            value.Guard("01234567", NumberBase.OCATAL);
        }
    }
}
