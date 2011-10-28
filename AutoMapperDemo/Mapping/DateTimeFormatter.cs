using System;
using AutoMapper;

namespace AutoMapperDemo.Mapping
{
    public class DateTimeFormatter : ValueFormatter<DateTime>
    {
        protected override string FormatValueCore(DateTime value)
        {
            return value.ToString("MMMM dd, yyyy");
        }
    }
}