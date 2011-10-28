using AutoMapper;

namespace AutoMapperDemo.Mapping
{
    public class StringToIntConverter : TypeConverter<string, int>
    {
        protected override int ConvertCore(string source)
        {
            int i;
            int.TryParse(source, out i);
            return i;
        }
    }
}