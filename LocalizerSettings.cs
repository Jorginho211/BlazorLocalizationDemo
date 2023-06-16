using System.Globalization;

namespace BlazorLocalizationDemo;

public static class LocalizerSettings
{
    public static List<(string name, CultureInfo culture)> SupportedCultures = new()
    {
        ("Español", new CultureInfo("es-Es")),
        ("Inglés", new CultureInfo("en-US"))
    };

    public static (string name, CultureInfo culture) NeutralCulture = SupportedCultures[0];
}