using System;

namespace VersionIncrementer.Extensions
{
    internal static class IncrementParser
    {
        public static Increment Parse(string increment)
        {
            if (!Enum.TryParse<Increment>(increment, out var incrementEnum))
                throw new Exception("Can not parse type");
            return incrementEnum;
        }
    }
}
