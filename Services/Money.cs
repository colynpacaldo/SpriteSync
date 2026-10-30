using System.Globalization;

namespace SpriteSync.Services;

public static class Money
{
    private static readonly CultureInfo Usd = CultureInfo.GetCultureInfo("en-US");
    public static string Format(decimal value) => value.ToString("C2", Usd);
}
