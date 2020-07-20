using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace FontAwesome.WPF.Extensions
{
    public static class FontAwesomeIconExtensions
    {
        /// <summary>
        /// Get the Typeface of an icon
        /// </summary>
        public static Typeface GetTypeFace(this FontAwesomeIcon icon)
        {
            var info = icon.GetInformationAttribute<FontAwesomeInformationAttribute>();
            if (info == null)
                return Fonts.RegularTypeface;

            return info.Style switch
            {
                FontAwesomeStyle.Regular => Fonts.RegularTypeface,
                FontAwesomeStyle.Solid => Fonts.SolidTypeface,
                FontAwesomeStyle.Brands => Fonts.BrandsTypeface,

                _ => null,
            };
        }

        public static FontFamily GetFontFamily(this FontAwesomeIcon icon)
        {
            var info = icon.GetInformationAttribute<FontAwesomeInformationAttribute>();
            if (info == null)
                return Fonts.RegularFontFamily;

            switch (info.Style)
            {
                case FontAwesomeStyle.Regular: return Fonts.RegularFontFamily;
                case FontAwesomeStyle.Solid: return Fonts.SolidFontFamily;
                case FontAwesomeStyle.Brands: return Fonts.BrandsFontFamily;
            }

            return null;
        }


        /// <summary>
        /// Get the Font Awesome label of an icon
        /// </summary>
        public static string GetLabel(this FontAwesomeIcon icon)
        {
            var info = icon.GetInformationAttribute<FontAwesomeInformationAttribute>();
            if (info == null)
                return null;

            return info.Label;
        }

        /// <summary>
        /// Get the Font Awesome Style of an icon
        /// </summary>
        public static FontAwesomeStyle GetStyle(this FontAwesomeIcon icon)
        {
            var info = icon.GetInformationAttribute<FontAwesomeInformationAttribute>();
            if (info == null)
                return FontAwesomeStyle.None;

            return info.Style;
        }

        /// <summary>
        /// Get the SVG path of an icon
        /// </summary>
        public static bool GetSvg(this FontAwesomeIcon icon, out string path, out int width, out int height)
        {
            path = string.Empty;
            width = -1;
            height = -1;


            var svgInfo = icon.GetInformationAttribute<FontAwesomeSvgInformationAttribute>();
            if (svgInfo == null)
                return false;

            path = svgInfo.Path;
            width = svgInfo.Width;
            height = svgInfo.Height;

            return true;
        }

        /// <summary>
        /// Get the Unicode of an icon
        /// </summary>
        public static string GetUnicode(this FontAwesomeIcon icon)
        {
            var info = icon.GetInformationAttribute<FontAwesomeInformationAttribute>();
            if (info == null)
                return char.ConvertFromUtf32(0);

            return char.ConvertFromUtf32(info.Unicode);
        }

        public static T GetInformationAttribute<T>(this FontAwesomeIcon icon) where T : class
        {
            if (icon == FontAwesomeIcon.None)
                return null;

            var memInfo = typeof(FontAwesomeIcon).GetMember(icon.ToString());
            if (memInfo.Length == 0)
                throw new Exception("FontAwesomeIcon not found.");

            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false)
                .ToList();

            if (!attributes.Any())
                throw new Exception("FontAwesomeInformationAttribute not found.");

            return attributes[0] as T;
        }

    }
}
