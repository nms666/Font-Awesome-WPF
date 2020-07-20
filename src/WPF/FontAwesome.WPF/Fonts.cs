﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace FontAwesome.WPF
{
    /// <summary>
    /// Provides FontFamilies and Typefaces of FontAwesome5.
    /// </summary>
    public static class Fonts
    {
        /// <summary>
        /// FontAwesome5 Regular FontFamily
        /// </summary>
        public static readonly FontFamily RegularFontFamily = new FontFamily(new Uri("pack://application:,,,/FontAwesome.WPF.Core;component/"), "./Fonts/#Font Awesome 5 Free Regular");
        /// <summary>
        /// FontAwesome5 Solid FontFamily
        /// </summary>
        public static readonly FontFamily SolidFontFamily = new FontFamily(new Uri("pack://application:,,,/FontAwesome.WPF.Core;component/"), "./Fonts/#Font Awesome 5 Free Solid");
        /// <summary>
        /// FontAwesome5 Brands FontFamily
        /// </summary>
        public static readonly FontFamily BrandsFontFamily = new FontFamily(new Uri("pack://application:,,,/FontAwesome.WPF.Core;component/"), "./Fonts/#Font Awesome 5 Brands Regular");

        /// <summary>
        /// FontAwesome5 Regular Typeface
        /// </summary>
        public static readonly Typeface RegularTypeface = new Typeface(RegularFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        /// <summary>
        /// FontAwesome5 Solid Typeface
        /// </summary>
        public static readonly Typeface SolidTypeface = new Typeface(SolidFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        /// <summary>
        /// FontAwesome5 Brands Typeface
        /// </summary>
        public static readonly Typeface BrandsTypeface = new Typeface(BrandsFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
    }
}
