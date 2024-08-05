namespace Oms.NumberSystem.Models
{
    public static class NumberSystemExtensions
    {
        public static void Guard(this string source, string allowedCharacters, NumberBase numberBase)
        {
            foreach (var ch in source)
            {
                if (!allowedCharacters.Contains(ch))
                {
                    throw new InvalidOperationException($"'{source}' is invalid {numberBase} format");
                }
            }
        }
        public static string To<T>(this T source, NumberBase toBase) where T : Base
        {
            NumberBase fromBase;
            switch (source)
            {
                case BinaryReader: fromBase = NumberBase.BINARY; break;
                case OctalSystem: fromBase = NumberBase.OCATAL; break;
                case DecimalSystem: fromBase = NumberBase.DECIMAL; break;
                case HexadecimalSystem: fromBase = NumberBase.HEXADECIMAL; break;
                default: fromBase = NumberBase.DECIMAL; break;
            }

            return Convert.ToString(Convert.ToInt32(source.Value, (int)fromBase), (int)toBase);
        }
    }
}
