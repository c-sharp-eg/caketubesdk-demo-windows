﻿// <copyright file="InvertCollapsedConverter.cs" company="AnchorFree Inc.">
// Copyright (c) AnchorFree Inc. All rights reserved.
// </copyright>
// <summary>Describes a InvertCollapsed Converter.</summary>

namespace CakeTubeSdk.Demo.Converter
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// <see cref="bool"/> to <see cref="Visibility"/> converter. true => Visibility.Collapsed, false => Visibility.Visible.
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class InvertCollapsedConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var original = (bool)value;
            return original ? Visibility.Collapsed : Visibility.Visible;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var original = (Visibility)value;
            return original == Visibility.Collapsed;
        }
    }
}