using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiComponents
{
    public class BorderlessEntry : Entry
    {
        public static BindableProperty UnderlineThicknessProperty = BindableProperty.Create(
           nameof(UnderlineThickness), typeof(int), typeof(BorderlessEntry), 0);
        public int UnderlineThickness
        {
            get => (int)GetValue(UnderlineThicknessProperty);
            set => SetValue(UnderlineThicknessProperty, value);
        }
    }
}
