using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WhatUI.Renderers
{
    public class ChatEntry : Editor
    {
        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
            "Placeholder", typeof(string), typeof(ChatEntry));

        public string Placeholder
        {
            get
            {
                return (string)GetValue(PlaceholderProperty);
            }
            set
            {
                SetValue(PlaceholderProperty, value);
            }
        }
    }
}
