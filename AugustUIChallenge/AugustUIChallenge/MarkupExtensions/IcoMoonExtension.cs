using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AugustUIChallenge
{
    [ContentProperty("Glyph")]
    public class IcoMoonExtension : IMarkupExtension<FontImageSource>
    {
        private const string LightKey = "TextColor";
        private const string DarkKey = "TextColorDark";

        private static Color _lightColor = Color.Default;
        private static Color _darkColor = Color.Default;

        public string Glyph { get; set; }
        public Color Color { get; set; }

        [TypeConverter(typeof(FontSizeConverter))]
        public double Size { get; set; } = (double)FontImageSource.SizeProperty.DefaultValue;

        public FontImageSource GetIcon()
        {
            var icon = new FontImageSource
            {
                Glyph = Glyph,
                Size = Size,
                FontFamily = "IcoMoonFont"
            };

            if (Color != Color.Default)
            {
                icon.Color = Color;
            }
            else
            {
                CacheColors();
                icon.SetAppThemeColor(FontImageSource.ColorProperty, _lightColor, _darkColor);
            }

            return icon;
        }

        private void CacheColors()
        {
            if (_lightColor == Color.Default && 
                Application.Current.Resources.TryGetValue(LightKey, out var lightRes))
            {
                _lightColor = (Color)lightRes;
            }

            if (_darkColor == Color.Default &&
                Application.Current.Resources.TryGetValue(DarkKey, out var darkRes))
            {
                _darkColor = (Color)darkRes;
            }
        }

        public FontImageSource ProvideValue(IServiceProvider serviceProvider) => GetIcon();
        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);
    }
}