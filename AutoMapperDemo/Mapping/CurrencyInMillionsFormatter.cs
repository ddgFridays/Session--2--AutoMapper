using AutoMapper;

namespace AutoMapperDemo.Mapping
{
    public class CurrencyInMillionsFormatter : ValueFormatter<decimal>
    {
        protected override string FormatValueCore(decimal value)
        {
            return value.ToString("C") + " million";
        }
    }
}